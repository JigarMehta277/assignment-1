using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment_1.Controllers
{
    /// <summary>
    /// This function returns Hello World! using post request
    /// <example>GET api/Greeting</example>
    /// </summary>
    /// <returns>Hello World!</returns>
    public class GreetingController : ApiController
    {
        public String Post()
        {
            return "Hello World!";
        }
    }
}
