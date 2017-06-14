using EFS.WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace EFS.WebAPI.Filters
{
    /// <summary>
    /// The token validation attribute.
    /// </summary>
    public class TokenValidationAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// The on action executing. Validates security token.
        /// </summary>
        /// <param name="actionContext">
        /// The action context.
        /// </param>
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            try
            {
                string token = actionContext.HttpContext.Request.Headers["Authorization"];
                var controller = (BaseController)actionContext.Controller;

                if (controller.TokenAuthentication.IsValid(token))
                {
                    base.OnActionExecuting(actionContext);
                }
                else
                {
                    var actionResult = new ContentResult() { Content = "Unauthorized Request", StatusCode = (int)HttpStatusCode.Forbidden };                    
                    actionContext.Result = actionResult;
                }
            }
            catch (Exception ex)
            {
                var actionResult = new ContentResult() { Content = "Missing Authorization Token", StatusCode = (int)HttpStatusCode.BadRequest };
                actionContext.Result = actionResult;
            }
        }
    }
}
