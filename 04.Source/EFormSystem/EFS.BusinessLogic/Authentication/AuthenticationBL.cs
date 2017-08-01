using EFS.APIModel.Users;
using EFS.BusinessLogic.Base;
using System;
using System.Collections.Generic;
using System.Text;
using EFS.Common.Global;
using AutoMapper;
using EFS.Model.Users;
using EFS.APIModel.Authentication;
using EFS.DataAccess.Users;
using EFS.Common.Encryption;

namespace EFS.BusinessLogic.Authentication
{
    public class AuthenticationBL : BaseBusinessLogic<UserItem>
    {
        private readonly IUserRepository _useRepository;
        private readonly IEncryptionService _encryptionService;

        public AuthenticationBL(AppConfigures configs, IEncryptionService encryptionService) : base(configs)
        {
            _useRepository = new UserRepository(configs.ConnectionString);
            _encryptionService = encryptionService;
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
                    Password = _encryptionService.Encrypt(item.Password, _options.Crypto.GetKey(), _options.Crypto.GetIV()),
                });                
            }

            return item;
        }

        public AuthenticationItem Login(AuthenticationItem item)
        {
            var encryptedPass = _encryptionService.Encrypt(item.Password, _options.Crypto.GetKey(), _options.Crypto.GetIV());
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
