using EFS.BusinessLogic.Authentication;
using EFS.BusinessLogic.Users;
using EFS.Common.Global;
using EFS.WebAPI.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using EFS.APIModel.Authentication;
using EFS.Common.Authentication;

namespace EFS.WebAPI.Controllers
{
    [UnhandledException]
    public class AuthenticationController : BaseController
    {
        private readonly AuthenticationBL _authBL;

        public AuthenticationController(
            IOptions<AppConfigures> optionsAccessor
            , ITokenAuthorizationService authenService) : base(optionsAccessor, authenService)
        {
            _authBL = new AuthenticationBL(_options);
        }

        [HttpPost]
        public IActionResult Login([FromBody]AuthenticationItem item)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                var user = _authBL.Login(item);

                if (user.IsValid)
                {
                    //item.Token = TokenAuth.GenerateToken(user);
                    return Ok(item);
                }
                else
                {
                    return StatusCode(500, item.ValidationErrors);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public IActionResult Register([FromBody]AuthenticationItem item)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                var user = _authBL.Register(item);

                if (user.IsValid)
                    return Ok(user);
                else
                    return StatusCode(500, user.ValidationErrors);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
