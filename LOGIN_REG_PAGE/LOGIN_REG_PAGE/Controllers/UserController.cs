using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LOGIN_REG_PAGE.Models;
namespace LOGIN_REG_PAGE.Controllers
{
    public class UserController : Controller
    {
        //private Freshers_Training2022Entities
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(MM_User account)
        {
            if (ModelState.IsValid)
            {
                using (Freshers_Training2022Entities adb = new Freshers_Training2022Entities())
                {
                    adb.MM_User.Add(account);
                    adb.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.Name + "Successfully Registered";
            }
            return RedirectToAction("LoggedIn");
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(MM_User user)
        {
            using (Freshers_Training2022Entities adb = new Freshers_Training2022Entities())
            {
                try
                {
                    var login_user = adb.MM_User.Single(u => u.Username == user.Username && u.Password == user.Password);
                    if (login_user != null)
                    {
                        Session["UserId"] = login_user.UserId.ToString();
                        Session["Username"] = login_user.Username.ToString();
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
            if (Session["UserId"] != null)
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

  