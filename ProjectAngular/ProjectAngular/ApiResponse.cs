using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAngular
{
    public class ApiResponse<T>
    {
        public string StatusCode { get; set; }
        public string Errors { get; set; }
        public T Response { get; set; }
    }
}
