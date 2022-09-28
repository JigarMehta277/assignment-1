using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment_1.Controllers
{
    /// <summary>
    /// This function returns message with input
    /// <example>GET api/Greetings2</example>
    /// </summary>
    /// <returns>Greetings to "+id+" people!</returns>
    public class Greeting2Controller : ApiController
    {
        public String Get(int id)
        {
            return "Greetings to "+id+" people!";
        }
    }
}
