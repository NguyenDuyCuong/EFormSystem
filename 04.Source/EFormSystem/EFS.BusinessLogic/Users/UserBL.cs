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
using EFS.DataAccess.Users;
using EFS.Common.Global;
using AutoMapper;

namespace EFS.BusinessLogic.Users
{
    public class UserBL : BaseBusinessLogic<UserItem>, IUserBL
    {
        public UserBL(AppConfigures configs) : base(configs)
        {
            _dataLayer = new UserDataAccess(_options.ConnectionString);
        }

        private IUserDataAccess _dataLayer;

        public UserItem FindByAuthToken(string authenticationToken)
        {
            throw new NotImplementedException();
        }

        public UserItem FindByUsername(string username)
        {
            var user = _dataLayer.FindByUsername(username);
            return Mapper.Map<UserItem>(user);
        }

        protected override void RegisterMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<User, UserItem>();
                cfg.CreateMap<UserItem, User>();
            });

            base.RegisterMapper();
        }
    }
}
