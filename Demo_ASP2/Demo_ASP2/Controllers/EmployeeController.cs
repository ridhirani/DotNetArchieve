using Demo_ASP2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_ASP2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeController1
        public ActionResult Index()
        {
            var employee = from e in GetEmployeeList()
                           orderby e.ID
                           select e;
                return View(employee);
        }

        // GET: EmployeeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public List<Employee> GetEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    ID = 1,
                    Name = "Ridhi",
                    DateofJoining = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 21,
                },
                new Employee
                {
                    ID = 2,
                    Name = "Karthik",
                    DateofJoining = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 21,
                },
                new Employee
                {
                    ID = 2,
                    Name = "shiv",
                    DateofJoining = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 21,
                },
                 new Employee
                {
                    ID = 3,
                    Name = "Raman",
                    DateofJoining = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 21,
                },


            };
        }
            }
}
