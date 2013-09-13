using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EShop.Web.Models;

namespace EShop.Web.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Login()
        {
            return View(new LoginUser());
        }

        [HttpPost]
        public ActionResult Login(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToActionPermanent("DashBoard");
            }
            return View();
        }

        public ActionResult DashBoard()
        {
            TempData["dashboard"] = "active";
            return View();
        }
    }
}


