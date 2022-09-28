using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment_1.Controllers
{
    /// <summary>
    /// This function returns total hosting cost.
    /// <example>GET api/HostingCost</example>
    /// </summary>
    /// <returns>"1 fortnights at $" + amount + "/FN = $" + total1 + "CAD, HST 13 %=" + HSTprice + "CAD, Total = $" + total2</returns>
    /// change
    public class HostingCostController : ApiController
    {
        public String Get(int id)
        {
            int night = 14;
            double amount = 5.50;
            double HST = 13;
            double total1;
            double total2;
            double HSTprice;

            int ans = id / night;
            if(ans==0)
            {
                ans = 1;
            }
            else
            {
                ans = ans + 1;
            }
            total1 = amount * ans;
            HSTprice = total1 * (HST / 100);
            total2 = total1 + HSTprice;
            return "1 fortnights at $" + amount + "/FN = $" + total1 + "CAD, HST 13 %=" + HSTprice + "CAD, Total = $" + total2;
             
        }
    }
}
