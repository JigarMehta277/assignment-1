using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment_1.Controllers
{
    /// <summary>
    /// This method returns input incremented by 10
    /// <example>GET api/AddTen</example>
    /// 
    /// </summary>
    /// <returns>id + 10</returns>
    public class AddTenController : ApiController
    {
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
