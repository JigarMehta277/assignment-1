using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace assignment_1.Controllers
{
    /// <summary>
    /// This function returns output after, input is passed through four mathematical operations
    /// <examples>GET api/NumberMachine</examples>
    /// </summary>
    /// <returns>multiplication</returns>
    public class NumberMachineController : ApiController
    {
        public double Get(double id)
        {
            double addition = id + 50;
            double divsion = addition / 10;
            double modulo = divsion % 6;
            double multiplication = modulo * 7;
            return multiplication;
        }
    }
}
