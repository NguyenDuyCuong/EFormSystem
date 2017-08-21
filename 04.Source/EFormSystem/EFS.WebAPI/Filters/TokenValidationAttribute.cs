using EFS.Common.Exceptions;
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
                var remoteIpAddress = actionContext.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
                var agent = actionContext.HttpContext.Request.Headers["User-Agent"].ToString();

                var controller = (BaseController)actionContext.Controller;
                
                if (controller.TokenAuth.IsTokenValid(token, remoteIpAddress, agent, (t) => controller.CheckUserToken(t)))
                {
                    base.OnActionExecuting(actionContext);
                }
                else
                {
                    var actionResult = new UnauthorizedResult();                    
                    actionContext.Result = actionResult;
                }
            }
            catch (BussinessException ex)
            {
                actionContext.Result = HandleException(ex);
            }
            catch (ServiceException ex)
            {                
                actionContext.Result = HandleException(ex);
            }
            catch (Exception ex)
            {
                var actionResult = new BadRequestResult();
                actionContext.Result = actionResult;
            }
        }

        private IActionResult HandleException(IEFSException ex)
        {
            // TODO: log error here

            IActionResult actionResult = new UnauthorizedResult();
            if (ex.ErrorType != EFS.Common.Global.ValidationErrorTypes.LogicError)
            {
                actionResult = new BadRequestResult();
            }

            return actionResult;
        }
    }
}
