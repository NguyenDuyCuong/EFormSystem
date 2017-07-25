using EFS.APIModel.Users;
using EFS.BusinessLogic.Base;
using EFS.Model.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.BusinessLogic.Users
{
    public interface IUserBL : IBusinessLogic<UserItem>
    {
        User FindByUsername(string username);
        User FindByAuthToken(string authenticationToken);
    }
}
