using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pharmacy.Controllers
{
    public class LoginController : Controller
    {
        Pharmacy_DBEntities7 db = new Pharmacy_DBEntities7();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(pharmacist objchk)
        {
            if (ModelState.IsValid)
            {
                using (Pharmacy_DBEntities7 db = new Pharmacy_DBEntities7())
                {
                    var obj = db.pharmacists.Where(a => a.Username.Equals(objchk.Username) && a.Password.Equals(objchk.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.UserID.ToString();
                        Session["Password"] = obj.Password.ToString();
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "The ID or Password Incorrect");
                    }
                }
            }

            return View(objchk);
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Login");
        }



    }
}