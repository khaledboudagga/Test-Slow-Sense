using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responses
{
    public class Response
    {

        public Response()
        {
            Data = null;
        }
        public int Status { get; set; }
        public string Message { get; set; }

        public object? Data { get; set; }

    }
}
