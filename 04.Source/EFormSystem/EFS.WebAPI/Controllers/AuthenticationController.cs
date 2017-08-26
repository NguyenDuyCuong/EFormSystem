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
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Localization;
using System.Reflection;

namespace EFS.WebAPI.Controllers
{
    [UnhandledException]
    public class AuthenticationController : BaseController
    {
        private readonly AuthenticationBL _authBL;

        public AuthenticationController(
            IOptions<AppConfigures> optionsAccessor
            , ITokenAuthorizationService authenService
            , ILoggerFactory loggerFactory) : base(optionsAccessor, authenService, loggerFactory)
        {
            _authBL = new AuthenticationBL(_options);
        }

        [HttpPost]
        public IActionResult Login([FromBody]Credential item)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                item.UserAgent = HttpContext.Request.Headers["User-Agent"].ToString();
                var isLoged = _authBL.Login(item);

                if (isLoged)
                {
                    return Ok(item);
                }
                else
                {
                    return StatusCode(403, item);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public IActionResult Register([FromBody]Credential item)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                var isRegisted = _authBL.Register(item);

                if (isRegisted)
                    return Ok(item);
                else
                    return StatusCode(500, item);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        public IActionResult GetIp()
        {
            var ip = this.HttpContext.Request.Headers["X-Forwarded-For"]; // AWS compatibility
            if (string.IsNullOrEmpty(ip))
            {
                ip = this.HttpContext.Request.Host.ToUriComponent();
            }
            return Json(ip);
        }
    }
}
