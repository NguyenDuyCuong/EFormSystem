using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EFS.WebAPI.Common
{
    public class GetDataResponse<T> : ResponseBase
    { 
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
