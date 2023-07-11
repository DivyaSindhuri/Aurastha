using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aurastha.Api.Models.DTO.Response
{
    public class BaseResponse
    {
        public object? Value { get; set; }
        public HttpStatusCode Code { get; set; }

        public BaseResponse(HttpStatusCode code)
        {
            Code = code;
        }
        public BaseResponse(object value, HttpStatusCode code)
        {
            Value = value;
            Code = code;
        }
    }
}
