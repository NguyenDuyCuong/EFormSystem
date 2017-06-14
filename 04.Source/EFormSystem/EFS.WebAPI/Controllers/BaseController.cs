using EFS.WebAPI.Authentication;
using Microsoft.AspNetCore.Mvc;
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
    }
}
