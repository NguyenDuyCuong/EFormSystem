using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFS.WebAPI.Filters
{
    /// <summary>
    /// The unhandled exception attribute.
    /// </summary>
    public class UnhandledExceptionAttribute : ExceptionFilterAttribute
    {
        /// <summary>
        /// The on exception.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        /// 
        public override void OnException(ExceptionContext context)
        {
            // TODO: write log
            base.OnException(context);
        }
    }
}
