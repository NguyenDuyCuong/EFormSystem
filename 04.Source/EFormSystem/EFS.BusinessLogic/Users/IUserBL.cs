using EFS.BusinessLogic.Base;
using EFS.Model.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.BusinessLogic.Users
{
    public interface IUserBL : IBusinessLogic<User>
    {
        /// <summary>
        /// Find user by username.
        /// </summary>
        /// <param name="username">
        /// The username.
        /// </param>
        /// <returns>
        /// The <see cref="User"/>.
        /// </returns>
        User FindByUsername(string username);

        /// <summary>
        /// The find by authentication token.
        /// </summary>
        /// <param name="authenticationToken">
        /// The request token.
        /// </param>
        /// <returns>
        /// The <see cref="User"/>.
        /// </returns>
        User FindByAuthToken(string authenticationToken);
    }
}
