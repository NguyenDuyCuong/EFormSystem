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

        public AuthenticationItem Register(AuthenticationItem item)
        {
            var user = _useRepository.FindByUsername(item.Username);
            if (user != null)
            {
                item.SetLogicError("Register", "UserName have been registed");
            }
            else
            {
                user = _useRepository.Insert(new User() {
                    Username = item.Username,
                    Password = Common.Helper.EncryptionHelper.Encrypt(item.Password, _options.Crypto.key, _options.Crypto.iv),
                });                
            }

            return item;
        }

        public UserItem CheckUserToken(Certificatate clientToken)
        {
            var user = _useRepository.FindByNamePass();

            return AutoMapper.Mapper.Map<UserItem>(user);
        }

        public AuthenticationItem Login(AuthenticationItem item)
        {
            var encryptedPass = Common.Helper.EncryptionHelper.Encrypt(item.Password, _options.Crypto.key, _options.Crypto.iv);
            var user = _useRepository.FindByNamePass(item.Username, encryptedPass);

            if (user != null)
            {
                item.LoginDate = DateTime.Now;
                item.Status = (int)AuthStatus.Login;

                return item;
            }

            item.Status = (int)AuthStatus.Fail;
            item.SetLogicError("Login", "Wrong username or password!");

            return item;
        }
    }
}
