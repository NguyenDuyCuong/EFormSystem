using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using EFS.APIModel.Authentication;

namespace EFS.WebAPI.Authentication
{
    /// <summary>
    /// The TokenAuthentication interface.
    /// </summary>
    public interface ITokenAuthentication
    {
        /// <summary>
        /// Gets the token.
        /// </summary>
        string Token { get; }

        /// <summary>
        /// The is valid.
        /// </summary>
        /// <param name="token">
        /// The token.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool IsValid(string token);

        string GenerateToken(AuthenticationItem user);
    }
}
