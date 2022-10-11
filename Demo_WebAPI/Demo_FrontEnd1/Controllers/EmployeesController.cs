using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Net.Http.Headers;
using System.Net.Http;
using Demo_FrontEnd1.Models;

namespace Demo_FrontEnd1.Controllers
{
    public class EmployeesController : Controller
    {
        private string Base_Url ="https://localhost:44302/api/";

        // GET: Employees
        public ActionResult Index()
        {
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri(Base_Url);
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("aplication/json"));
            //HttpResponseMessage message = client.GetAsync("Employee").Result;
            //if (message.IsSuccessStatusCode)
            //{
            //    return message.Content.ReadAsStringAsync<IEnumerable<Employees>>().Result;
            //}
            EmployeeClient ec = new EmployeeClient();
            ViewBag.ListEmployees = ec.Find();

            return View();

        }
        //public ActionResult Find(int id)
        //{
        //    EmployeeClient ec = new EmployeeClient();
        //    ViewBag.ListEmployees = ec.Find();

        //    return View();

        //}
    }
}