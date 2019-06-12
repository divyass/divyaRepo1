using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Dynamic;
using System.Web.Http;

namespace HelloWebApi
{
    public class HelloApiController : ApiController
    {
        public string Get() {
            Console.WriteLine("Conflict check");
            return "hello";
        }
    }
}