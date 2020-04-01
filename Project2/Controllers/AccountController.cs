using Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Project2.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(TBL_USER_D user)
        {

            PathologyEntities1 db = new PathologyEntities1();

            var usr = db.TBL_USER_D.SingleOrDefault(x => x.USER_NAME == user.USER_NAME && x.USER_PASSWORD == user.USER_PASSWORD);
            if (usr != null)
            {

                if (usr.MAG_ACT ==1)
                {
                    FormsAuthentication.SetAuthCookie(usr.USER_NAME, false);
                    return RedirectToAction("AdminDashboard", "Home", new { user = user.USER_NAME });
                }
                else if (usr.MAG_ACT == 2)
                {
                    FormsAuthentication.SetAuthCookie(usr.USER_NAME, false);
                    return RedirectToAction("StudentDashBaord", "Home");
                }
                else
                {
                    FormsAuthentication.SetAuthCookie(usr.USER_NAME ,false);
                    return RedirectToAction("staffDashboard", "Home", new { id = usr.USER_NAME });
                }

            }
            else
            {
                ViewBag.triedOnce = "yes";
                return View();
            }
        }


        public ActionResult Logout()
        {
            //FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }

    }
}