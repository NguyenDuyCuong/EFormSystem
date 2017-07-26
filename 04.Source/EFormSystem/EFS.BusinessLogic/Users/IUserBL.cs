using EFS.APIModel.Users;
using EFS.BusinessLogic.Base;
using EFS.DataAccess.Users;
using EFS.Model.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.BusinessLogic.Users
{
    public interface IUserBL : IBusinessLogic<UserItem>
    {
        IUserDataAccess DataLayer { get; set; }

        User FindByUsername(string username);
        User FindByAuthToken(string authenticationToken);
    }
}
