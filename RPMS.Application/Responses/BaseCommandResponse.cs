using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Application.Responses
{
    public class BaseCommandResponse<T>
    {
        public HttpStatusCode StatusCode { set; get; }
        public T? Reponse { set; get; }
        public object? ValidationError { set; get; }
        public string? Message { set; get; }
    }
}
