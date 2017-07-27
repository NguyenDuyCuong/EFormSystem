using EFS.DataAccess.Base;
using EFS.Model.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.DataAccess.Users
{
    /// <summary>
    /// The UserDataMapper interface.
    /// </summary>
    public interface IUserDataAccess : IDataAccess<User>
    {
        User FindByUsername(string username);

        User FindByAuthToken(string authenticationToken);
    }
}
