using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment_1.Controllers
{
    /// <summary>
    /// This method returns square of input
    /// <example>GET api/Square</example>
    /// </summary>
    /// <returns>id*id</returns>
    public class SquareController : ApiController
    {
        public int Get(int id)
        {
            return id*id;
        }
    }
}
