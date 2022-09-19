using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_HelloWorld.Controllers
{
    public class Hello_WorldController : Controller
    {
        // GET: Hello_WorldController
        public string Index()
        {
            return "T";
        }

        // GET: Hello_WorldController/Details/5
        public string Details(string name)
        {
            return "hello Welcome:" +name;
        }

        // GET: Hello_WorldController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hello_WorldController/Create
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

        // GET: Hello_WorldController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hello_WorldController/Edit/5
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

        // GET: Hello_WorldController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hello_WorldController/Delete/5
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
    }
}
