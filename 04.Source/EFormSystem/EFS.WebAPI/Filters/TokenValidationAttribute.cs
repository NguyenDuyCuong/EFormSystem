﻿using EFS.WebAPI.Controllers;
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

                if (token == null && actionContext.HttpContext.Request.Method == "get")
                    return;

                var controller = (BaseController)actionContext.Controller;

                if (controller.TokenAuth.IsValid(token))
                {
                    base.OnActionExecuting(actionContext);
                }
                else
                {
                    var actionResult = new UnauthorizedResult();                    
                    actionContext.Result = actionResult;
                }
            }
            catch (Exception ex)
            {
                var actionResult = new BadRequestResult();
                actionContext.Result = actionResult;
            }
        }
    }
}
