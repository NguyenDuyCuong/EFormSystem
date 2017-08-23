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
        public Credential Token
        {
            get; private set;
        }

        private AppConfigures _options;

        public void InitParams(AppConfigures config)
        {
            _options = config;
        }
                
        public bool IsTokenValid(string token, string ip, string userAgent, Func<Credential, bool> funcCheckUser)
        {
            bool result = false;

            if (String.IsNullOrEmpty(token))
                return false;

            var clientCerificate = new Credential(token, ip, userAgent);

            if (!clientCerificate.IsExpired(_options.ExpirationMinutes))
            {
                //var _expirationMinutes = _options.ExpirationMinutes;
                //// Base64 decode the string, obtaining the token:username:timeStamp.
                //string key = Encoding.UTF8.GetString(Convert.FromBase64String(token));
                //// Split the parts.
                //string[] parts = key.Split(new char[] { ':' });
                //if (parts.Length == 3)
                //{
                //    // Get the hash message, username, and timestamp.
                //    string hash = parts[0];
                //    string username = parts[1];
                //    long ticks = long.Parse(parts[2]);
                //    DateTime timeStamp = new DateTime(ticks);
                //    // Ensure the timestamp is valid.
                //    bool expired = Math.Abs((DateTime.UtcNow - timeStamp).TotalMinutes) > _expirationMinutes;
                //    if (!expired)
                //    {
                //        //
                //        // Lookup the user's account from the db.
                //        //
                //        if (username == "john")
                //        {
                //            string password = "password";
                //            // Hash the message with the key to generate a token.
                //            string computedToken = GenerateToken(username, password, ip, userAgent, ticks);
                //            // Compare the computed token with the one supplied and ensure they match.
                //            result = (token == computedToken);
                //        }
                //    }
                //}

                result = funcCheckUser(clientCerificate);
            }

            return result;
        }
    }
}
