using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.Http;

namespace HelloWebApi
{
    public class HelloApiController : ApiController
    {
        public string Get()
        {
            Console.WriteLine("Conflict it is");
            return "hello";

        }
    }
}