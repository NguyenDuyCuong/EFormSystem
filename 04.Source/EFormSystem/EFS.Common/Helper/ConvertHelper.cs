using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFS.Common.Helper
{
    public static class ConvertHelper
    {
        public static string ConvertToJsonString(params object[] args)
        {
            var inputCollection = args.Select(arg =>
            {
                var argType = arg.GetType();

                return new { argType.Name, arg };
            });
            
            // TODO: to json here
            return null;
        }
    }
}
