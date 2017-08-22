using Dapper;
using EFS.DataAccess.Base;
using EFS.Model.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace EFS.DataAccess.Users
{
    public class UserRepository : BaseRepository<AppUser>, IUserRepository
    {
        public UserRepository(string strConnection) : base(strConnection)
        {
        }


        /// <summary>
        /// Find by username.
        /// </summary>
        /// <param name="username">
        /// The username.
        /// </param>
        /// <returns>
        /// The <see cref="User"/>.
        /// </returns>
        public AppUser FindByUsername(string username)
        {
            return FindSingle("SELECT * FROM AppUser WHERE Username=@Username", new { Username = username });
        }

        public AppUser FindByNamePass(string username, string password)
        {
            return FindSingle("SELECT * FROM AppUser WHERE Username=@Username AND PasswordHash=@Pass", new { Username = username, Pass = password });
        }

        /// <summary>
        /// Find user by authentication token.
        /// </summary>
        /// <param name="authenticationToken">The authentication token</param>
        /// <returns>
        /// The <see cref="User"/>.
        /// </returns>
        public AppUser FindByAuthToken(string authenticationToken)
        {
            // TODO: Add real implementation. This is a stub
            return FindSingle("SELECT TOP 1 * FROM AppUser", new { AuthToken = authenticationToken });
        }

        public AppUser FindByNameToken(string userName, string token)
        {
            return FindSingle("Select Top 1 * from AppUser where UserName=@UserName and Token=@Token", new { UserName = userName, Token = token });
        }
    }
}
