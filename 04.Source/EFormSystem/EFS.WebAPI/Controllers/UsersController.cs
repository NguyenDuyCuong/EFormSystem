using EFS.APIModel.Users;
using EFS.BusinessLogic.Users;
using EFS.Common.Global;
using EFS.Model.Users;
using EFS.WebAPI.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;
using EFS.Common.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Localization;

namespace EFS.WebAPI.Controllers
{
    [TokenValidation]
    [UnhandledException]
    public class UsersController : BaseController
    {
        private readonly IUserBL _userBL;

        public UsersController(
            IOptions<AppConfigures> optionsAccessor
            , ITokenAuthorizationService authenService
            , ILoggerFactory loggerFactory
            , IStringLocalizer localizer) : base(optionsAccessor, authenService, loggerFactory, localizer)
        {
            _userBL = new UserBL(_options);
        }
        
        [HttpPost]
        public IActionResult Test()
        {
            return Ok();
        }
    }
}
