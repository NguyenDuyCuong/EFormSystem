using EFS.Common.Global;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace EFS.Common.Authentication
{
    public class Credential
    {
        [JsonProperty("username")]
        public string UserName { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("ip")]
        public string IP { get; set; }
        [JsonProperty("useragent")]
        public string UserAgent { get; set; }
        [JsonProperty("ticks")]
        public long Ticks { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }

        public Credential()
        {
            
        }

        public Credential(string token)
        {
            this.Token = token;
            ExtractToken(token);
        }

        public Credential(string token, string ip, string userAgent)
        {
            this.Token = token;
            this.IP = ip;
            this.UserAgent = userAgent;
            ExtractToken(token);
        }

        public bool IsExpired(int expirationMinutes)
        {
            var result = true;

            if (!String.IsNullOrEmpty(this.Token) && Ticks != 0)
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

        public string GenerateToken()
        {
            var _alg = Encoding.UTF8.GetBytes(AppConsts.SecretKey); //"HmacSHA256";

            string hash = string.Join(":", new string[] { this.UserName, this.IP, this.UserAgent, this.Ticks.ToString() });
            string hashLeft = "";
            string hashRight = "";
            using (HMAC hmac = new HMACSHA256(_alg))
            {
                hmac.Key = Encoding.UTF8.GetBytes(GetHashedPassword(this.Key));
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
