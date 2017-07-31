using EFS.APIModel.Authentication;
using EFS.BusinessLogic.Users;
using EFS.Common.Encryption;
using EFS.Common.Global;
using EFS.WebAPI.Filters;
using EFS.WebAPI.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EFS.WebAPI.Controllers
{
    [UnhandledException]
    public class AuthenticationController : BaseController
    {
        private readonly IEncryptionService _encryptionService;
        private readonly IUserBL _userBL;

        public AuthenticationController(
            IEncryptionService encryptionService,
            IOptions<AppConfigures> optionsAccessor) : base(optionsAccessor)
        {
            _userBL = new UserBL(_options);
            _encryptionService = encryptionService;
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody]AuthenticationItem item)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                var user = _userBL.FindByUsername(item.Username);

                if (user != null)
                {
                    if (user.Password == item.EncryptedPass)
                    {
                        item.Token = TokenAuthentication.Token;
                        item.Status = (int)Shared.AppEnums.AuthStatus.Login;
                        item.LoginDate = DateTime.Now;
                    }
                }
                else
                {
                    item.Status = (int)Shared.AppEnums.AuthStatus.Fail;
                    return NotFound(item);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }

            return Json(item);
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register([FromBody]AuthenticationItem item)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                var user = _userBL.CreateUser(item.Username, item.EncryptedPass);

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }

            return Json(item);
        }
    }
}
