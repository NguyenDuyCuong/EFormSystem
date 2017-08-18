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
    public class UserRepository : BaseRepository<User>, IUserRepository
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
        public User FindByUsername(string username)
        {
            return FindSingle("SELECT * FROM [User] WHERE Username=@Username", new { Username = username });
        }

        public User FindByNamePass(string username, byte[] password)
        {
            return FindSingle("SELECT * FROM [User] WHERE Username=@Username AND Password=@Pass", new { Username = username, Pass = password });
        }

        /// <summary>
        /// Find user by authentication token.
        /// </summary>
        /// <param name="authenticationToken">The authentication token</param>
        /// <returns>
        /// The <see cref="User"/>.
        /// </returns>
        public User FindByAuthToken(string authenticationToken)
        {
            // TODO: Add real implementation. This is a stub
            return FindSingle("SELECT TOP 1 * FROM [User]", new { AuthToken = authenticationToken });
        }
    }
}
