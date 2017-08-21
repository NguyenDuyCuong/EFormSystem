using EFS.Common.Global;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace EFS.Common.Authentication
{
    public class Certificatate
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public string IP { get; set; }
        public string UserAgent { get; set; }

        public long Ticks { get; set; }

        private string _token;
        public string Token { get; private set; }

        public Certificatate(string token)
        {
            this._token = token;
            ExtractToken(token);
        }

        public Certificatate(string token, string ip, string userAgent)
        {
            this._token = token;
            this.IP = ip;
            this.UserAgent = userAgent;
            ExtractToken(token);
        }

        public bool IsExpired(string token, int expirationMinutes)
        {
            var result = true;
            
            if (!String.IsNullOrEmpty(token) && Ticks != 0)
            {
                DateTime timeStamp = new DateTime(this.Ticks);
                result = Math.Abs((DateTime.UtcNow - timeStamp).TotalMinutes) > expirationMinutes;
            }

            return result;
        }

        private void ExtractToken(string token)
        {
            string key = Encoding.UTF8.GetString(Convert.FromBase64String(token));

            // Split the parts.
            string[] parts = key.Split(new char[] { ':' });
            if (parts.Length == 3)
            {
                // Get the hash message, username, and timestamp.
                this.UserName = parts[1];
                this.Ticks = long.Parse(parts[2]);
            }
        }

        private string GenerateToken()
        {
            var _alg = Encoding.UTF8.GetBytes(AppConsts.SecretKey); //"HmacSHA256";

            string hash = string.Join(":", new string[] { this.UserName, this.IP, this.UserAgent, this.Ticks.ToString() });
            string hashLeft = "";
            string hashRight = "";
            using (HMAC hmac = new HMACSHA256(_alg))
            {
                hmac.Key = Encoding.UTF8.GetBytes(GetHashedPassword(this.Password));
                var outHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(hash));
                hashLeft = Convert.ToBase64String(outHash);
                hashRight = string.Join(":", new string[] { this.UserName, this.Ticks.ToString() });
            }
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Join(":", hashLeft, hashRight)));
        }

        private string GetHashedPassword(string password)
        {
            var _alg = Encoding.UTF8.GetBytes(AppConsts.SecretKey);
            string _salt = AppConsts.SecretIV;

            string key = string.Join(":", new string[] { password, _salt });
            using (HMAC hmac = new HMACSHA256(_alg))
            {
                // Hash the key.
                hmac.Key = Encoding.UTF8.GetBytes(_salt);
                var outHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(key));
                return Convert.ToBase64String(outHash);
            }
        }
    }
}
