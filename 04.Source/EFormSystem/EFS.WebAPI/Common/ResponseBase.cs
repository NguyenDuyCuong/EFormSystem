using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EFS.WebAPI.Common
{
    public class ResponseBase
    {
        public HttpStatusCode StatusCode { get; set; }
    }
}
