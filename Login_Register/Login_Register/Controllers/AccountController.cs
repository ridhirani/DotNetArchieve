using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login_Register.Models;

namespace Login_Register.Controllers
{
    public class AccountController : Controller
    {

        // GET: Account
        public ActionResult Index()
        {
            using (Freshers_Training2022Entities adb = new Freshers_Training2022Entities())
            {
                return View(adb.userAccounts.ToList());


            }
        }
        public ActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Register(UserAccount account)
        {
            if (ModelState.IsValid)
            {
                using (Freshers_Training2022Entities adb = new Freshers_Training2022Entities())
                {
                    adb.userAccounts.Add(account);
                    adb.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.FirstName + "" + account.LastName + "Successfully Registered";
            }
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserAccount user)
        {
            using(Freshers_Training2022Entities adb = new Freshers_Training2022Entities())
            {
                var login_user = adb.userAccounts.Single(u => u.UserName == user.UserName && u.Password == user.Password);
                if (login_user!=null)
                {
                    Session["UserID"] = login_user.UserID.ToString();
                    Session["UserName"] = login_user.UserName.ToString();
                    return RedirectToAction("LoggedIn");

                }
                else
                {
                    ModelState.AddModelError("", "Username or Password is incorrect");
                }
            }
            return View();

        }

        public ActionResult LoggedIn()
        {
            if (Session["UserID"]!=null)
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