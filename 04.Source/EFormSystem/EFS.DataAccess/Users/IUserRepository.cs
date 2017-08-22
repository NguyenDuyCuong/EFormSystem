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
    public interface IUserRepository : IRepository<AppUser>
    {
        AppUser FindByUsername(string username);
        AppUser FindByNamePass(string username, byte[] password);
        AppUser FindByNameToken(string userName, string token);
    }
}
