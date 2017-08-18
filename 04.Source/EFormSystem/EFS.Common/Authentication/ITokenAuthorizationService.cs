using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace EFS.Common.Authentication
{
    /// <summary>
    /// The TokenAuthentication interface.
    /// </summary>
    public interface ITokenAuthorizationService
    {
        /// <summary>
        /// Gets the token.
        /// </summary>
        string Token { get; }

        bool IsTokenValid(string token, string ip, string userAgent);
    }
}
