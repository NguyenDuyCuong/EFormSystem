using EFS.APIModel.Base;
using EFS.BusinessLogic.Authentication;
using EFS.BusinessLogic.Base;
using EFS.Common.Authentication;
using EFS.Common.Global;
using EFS.DataAccess.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading.Tasks;

namespace EFS.WebAPI.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        /// Gets or sets the token authentication.
        /// </summary>
        public ITokenAuthorizationService TokenAuth { get; set; }
        private readonly AuthenticationBL _authBL;

        protected readonly AppConfigures _options;
        protected readonly ILogger _logger;

        public BaseController(IOptions<AppConfigures> optionsAccessor, ITokenAuthorizationService authenService, ILoggerFactory loggerFactory)
        {
            _options = optionsAccessor.Value;
            _logger = loggerFactory.CreateLogger(GetType());

            authenService.InitParams(_options);
            TokenAuth = authenService;

            _authBL = new AuthenticationBL(_options);
        }
        
        public bool CheckUserToken(Credential clientToken)
        {
            return _authBL.ValideUserToken(clientToken);
        }
    }
}
