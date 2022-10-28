/* Caroline Hana
10-25-2022
Adding 2 numbers with inputs
Peer Review - Elizar Garcia, code works great! controller is set up well and shows up on postman without a problem. Adds the numbers i put in with the correct output. Great job!!
*/


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HanaC_Add2NumbersEndpoint.Controllers
{
    [Route("[controller]")]
    public class Add2Numbers : Controller
    {
        [HttpGet]
        [Route("2Numbers/{number1}/{number2}")]

        public int addnum(string number1, string number2)
        {
            int convertnum1 = Convert.ToInt32(number1);
            int convertnum2 = Convert.ToInt32(number2);

            return convertnum1 + convertnum2;
        }
    }
}