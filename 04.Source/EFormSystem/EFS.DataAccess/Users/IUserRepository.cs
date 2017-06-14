using EFS.DataAccess.Base;
using EFS.Model.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.DataAccess.Users
{
    /// <summary>
    /// The UserRepository interface.
    /// </summary>
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// The find by username.
        /// </summary>
        /// <param name="username">
        /// The username.
        /// </param>
        /// <returns>
        /// The <see cref="User"/>.
        /// </returns>
        User FindByUsername(string username);
    }
}
