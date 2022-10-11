using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo_Authentication_MVc.Controllers;
using System.Web.Security;//Form authentication
using Demo_Authentication_MVc.Models;

namespace Demo_Authentication_MVc.Controllers
{
    public class HomeController : Controller
    {
        private readonly Freshers_Training2022Entities _dbContext = new Freshers_Training2022Entities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {

     
            return View();
        }
        [HttpPost]

        [ValidateAntiForgeryToken]
        public ActionResult Login(Form_Users user)
        {
            if (!ModelState.IsValid)
            {
                bool IsValidUser = _dbContext.Form_Users.Any(x => x.Username.ToLower() == user.Username.ToLower() &&
                user.Password == user.Password) ;
                if (IsValidUser)

                {

                    FormsAuthentication.SetAuthCookie(user.Username, false);
                    return RedirectToAction("Index", "Employee");

                }
            }
        

            ModelState.AddModelError(" ", "INVALID USERNAME or PASSWORD"); 

            return View();

         }

        [HttpPost]

        [ValidateAntiForgeryToken]
        public ActionResult Register(Form_Users registereuser)
        {
            if (ModelState.IsValid)

            {

                _dbContext.Form_Users.Add(registereuser);

                _dbContext.SaveChanges();

                return RedirectToAction("Login");

            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
            
        }

    }
}