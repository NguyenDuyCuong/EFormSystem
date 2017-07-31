using EFS.APIModel.Users;
using EFS.BusinessLogic.Users;
using EFS.Common.Encryption;
using EFS.Common.Global;
using EFS.Model.Users;
using EFS.WebAPI.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFS.WebAPI.Controllers
{
    [TokenValidationAttribute]
    public class UsersController : BaseController
    {
        private readonly IEncryptionService _encryptionService;
        private readonly IUserBL _userBL;

        public UsersController(
            IUserBL userBL,
            IEncryptionService encryptionService,
            IOptions<AppConfigures> optionsAccessor): base(optionsAccessor)
        {
            _userBL = userBL;
            _encryptionService = encryptionService;
        }
    }
}
