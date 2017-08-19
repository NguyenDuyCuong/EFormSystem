using EFS.APIModel.Base;
using EFS.BusinessLogic.Base;
using EFS.Common.Authentication;
using EFS.Common.Global;
using EFS.DataAccess.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFS.WebAPI.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        /// Gets or sets the token authentication.
        /// </summary>
        public ITokenAuthorizationService TokenAuth { get; set; }
        protected readonly AppConfigures _options;

        public BaseController(IOptions<AppConfigures> optionsAccessor, ITokenAuthorizationService authenService)
        {
            _options = optionsAccessor.Value;
            TokenAuth = authenService;
        }
    }
}
