using EFS.Common.Exceptions;
using EFS.Common.Global;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EFS.Common.Authentication
{
    /// <summary>
    /// The FormsAuthentication interface.
    /// </summary>
    public class TokenAuthorizationService : ITokenAuthorizationService
    {
        public string Token
        {
            get; private set;
        }

        protected readonly AppConfigures _options;

        public TokenAuthorizationService(AppConfigures options)
        {
            // HACK: something wrong here
            _options = options;
        }

        public string GenerateToken(string username, string password, string ip, string userAgent, long ticks)
        {
            var _alg = Encoding.UTF8.GetBytes(_options.Crypto.key); //"HmacSHA256";

            string hash = string.Join(":", new string[] { username, ip, userAgent, ticks.ToString() });
            string hashLeft = "";
            string hashRight = "";
            using (HMAC hmac = new HMACSHA256(_alg))
            {
                hmac.Key = Encoding.UTF8.GetBytes(GetHashedPassword(password));
                var outHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(hash));
                hashLeft = Convert.ToBase64String(outHash);
                hashRight = string.Join(":", new string[] { username, ticks.ToString() });
            }
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Join(":", hashLeft, hashRight)));
        }
        
        public bool IsTokenValid(string token, string ip, string userAgent)
        {
            bool result = false;

            if (!String.IsNullOrEmpty(token) && !IsExpired(token))
            {
                var _expirationMinutes = _options.ExpirationMinutes;
                // Base64 decode the string, obtaining the token:username:timeStamp.
                string key = Encoding.UTF8.GetString(Convert.FromBase64String(token));
                // Split the parts.
                string[] parts = key.Split(new char[] { ':' });
                if (parts.Length == 3)
                {
                    // Get the hash message, username, and timestamp.
                    string hash = parts[0];
                    string username = parts[1];
                    long ticks = long.Parse(parts[2]);
                    DateTime timeStamp = new DateTime(ticks);
                    // Ensure the timestamp is valid.
                    bool expired = Math.Abs((DateTime.UtcNow - timeStamp).TotalMinutes) > _expirationMinutes;
                    if (!expired)
                    {
                        //
                        // Lookup the user's account from the db.
                        //
                        if (username == "john")
                        {
                            string password = "password";
                            // Hash the message with the key to generate a token.
                            string computedToken = GenerateToken(username, password, ip, userAgent, ticks);
                            // Compare the computed token with the one supplied and ensure they match.
                            result = (token == computedToken);
                        }
                    }
                }
            }                
            
            return result;
        }

        private string GetHashedPassword(string password)
        {
            var _alg = Encoding.UTF8.GetBytes(_options.Crypto.key); //"HmacSHA256";
            string _salt = _options.Crypto.iv; //"rz8LuOtFBXphj9WQfvFh";

            string key = string.Join(":", new string[] { password, _salt });
            using (HMAC hmac = new HMACSHA256(_alg))
            {
                // Hash the key.
                hmac.Key = Encoding.UTF8.GetBytes(_salt);
                var outHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(key));
                return Convert.ToBase64String(outHash);
            }
        }

        private bool IsExpired(string token)
        {
            if (String.IsNullOrEmpty(token))
                throw new ServiceException("Token is empty.", this.ToString(), Common.Helper.ConvertHelper.ConvertToJsonString(token));

            var result = true;
            var _expirationMinutes = _options.ExpirationMinutes;

            // Base64 decode the string, obtaining the token:username:timeStamp.
            string key = Encoding.UTF8.GetString(Convert.FromBase64String(token));
            // Split the parts.
            string[] parts = key.Split(new char[] { ':' });
            if (parts.Length == 3)
            {
                // Get the hash message, username, and timestamp.
                string hash = parts[0];
                string username = parts[1];
                long ticks = long.Parse(parts[2]);
                DateTime timeStamp = new DateTime(ticks);
                // Ensure the timestamp is valid.
                result = Math.Abs((DateTime.UtcNow - timeStamp).TotalMinutes) > _expirationMinutes;
            }

            return result;
        }
    }
}
