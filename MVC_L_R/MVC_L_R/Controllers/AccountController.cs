using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_L_R.Models;

namespace MVC_L_R.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        //public ActionResult Index()
        //{
        //    using (OurDbContext adb = new OurDbContext())
        //    {
        //        return View(adb.userAccount.ToList());
        //    }
        //}
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserAccount account)
        {
            if (ModelState.IsValid)
            {
                using (OurDbContext adb =  new OurDbContext())
                {
                    adb.userAccount.Add(account);
                    adb.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.FirstName + "" + "Successfully Registered";
            }
            return RedirectToAction("LoggedIn");
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserAccount user)
        {
            using (OurDbContext adb = new OurDbContext())
            {
                try
                {
                    var login_user = adb.userAccount.Single(u => u.UserName == user.UserName && u.Password == user.Password);
                    if (login_user != null)
                    {
                        Session["UserID"] = login_user.UserID.ToString();
                        Session["UserName"] = login_user.UserName.ToString();
                        return RedirectToAction("LoggedIn");

                    }
                   
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Username or Password is incorrect");

                    ///throw;
                }


            }
            return View();

        }

        public ActionResult LoggedIn()
        {
            if (Session["UserID"] != null)
            {
                return View();

            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}
