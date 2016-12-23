using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using projethch.EF;
using projethch.Models;

namespace projethch.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult login()
        {
            return View();

        }

        public ActionResult dologin(string TXTusername, string txtpassword)

        {
            Dal _oDal = new Dal();
            User _user= new User();
            _user = (
                from frm in _oDal.users.ToList()
                         where frm.password == txtpassword && frm.IsActive == true select frm)
                    .Single();
            if (_user != null)

            {

                FormsAuthentication.SetAuthCookie(_user.Username,false);
                return RedirectToAction("Index", "Employee");

            }
            else
            {
                return View("login");

            }
        }
    }
}