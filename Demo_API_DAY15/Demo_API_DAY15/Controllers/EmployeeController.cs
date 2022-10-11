using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo_API_DAY15.Controllers
{
    public class EmployeeController : ApiController
    {
        //[HttpGet]
        public string GetGreet(string name)
        {
            return "Wlcome" + name;
        }
    }
}
