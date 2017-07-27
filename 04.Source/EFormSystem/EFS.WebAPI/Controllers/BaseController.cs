using EFS.APIModel.Base;
using EFS.BusinessLogic.Base;
using EFS.Common.Global;
using EFS.DataAccess.Base;
using EFS.WebAPI.Authentication;
using EFS.WebAPI.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class BaseController : Controller
    {
        /// <summary>
        /// Gets or sets the token authentication.
        /// </summary>
        public ITokenAuthentication TokenAuthentication { get; set; }

        /// <summary>
        /// Gets the request token.
        /// </summary>
        public string RequestToken
        {
            get
            {
                return HttpContext.Request.Headers["Authorization"];
            }
        }

        protected readonly AppConfigures _options;

        public BaseController(IOptions<AppConfigures> optionsAccessor)
        {
            _options = optionsAccessor.Value;
        }
    }
}
