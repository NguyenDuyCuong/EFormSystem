using EFS.APIModel.Users;
using EFS.BusinessLogic.Base;
using System;
using System.Collections.Generic;
using System.Text;
using EFS.Common.Global;
using AutoMapper;
using EFS.Model.Users;
using EFS.DataAccess.Users;
using EFS.APIModel.Authentication;
using EFS.Common.Authentication;
using EFS.Common.Exceptions;

namespace EFS.BusinessLogic.Authentication
{
    public class AuthenticationBL : BaseBusinessLogic<UserItem>
    {
        private readonly IUserRepository _useRepository;

        public AuthenticationBL(AppConfigures configs) : base(configs)
        {
            _useRepository = new UserRepository(configs.ConnectionString);
        }

        protected override void RegisterMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<User, UserItem>();
                cfg.CreateMap<UserItem, User>();
            });
        }

        public bool Register(Credential item)
        {
            var user = _useRepository.FindByUsername(item.UserName);
            if (user != null)
            {
                throw new BussinessException("User have been registed!", this.ToString(), Common.Helper.ConvertHelper.ConvertToJsonString(item));
            }
            else
            {
                user = _useRepository.Insert(new AppUser() {
                    UserName = item.UserName,
                    PasswordHash = item.Key,
                    Email = item.UserName,
                });

                return true;
            }
        }

        public bool ValideUserToken(Credential clientToken)
        {
            var user = _useRepository.FindByNameToken(clientToken.UserName, clientToken.Token);
            if (user == null)
                return false;

            var serverToken = new Credential(user.Token);
            if (serverToken.IsExpired(_options.ExpirationMinutes))
                return false;

            return serverToken.Token == clientToken.Token;
        }

        public bool Login(Credential item)
        {
            var result = false;
            var user = _useRepository.FindByNamePass(item.UserName, item.Key);

            if (user != null)
            {
                user.Token = item.Token;
                user.LastLogin = DateTime.Now;
                
                _useRepository.Update(user);

                result = true;
            }

            return result;
        }
    }
}
