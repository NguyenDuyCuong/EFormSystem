using System;
using System.Collections.Generic;
using System.Text;
using EFS.BusinessLogic.Base;
using EFS.Model.Users;
using System.Data;
using Dapper;
using EFS.Common.Encryption;
using System.Linq;
using EFS.APIModel.Users;

namespace EFS.BusinessLogic.Users
{
    public class UserBL : AbstractBusinessLogic<UserItem>, IUserBL
    {
        public User FindByAuthToken(string authenticationToken)
        {
            throw new NotImplementedException();
        }

        public User FindByUsername(string username)
        {
            throw new NotImplementedException();
        }
    }
}
