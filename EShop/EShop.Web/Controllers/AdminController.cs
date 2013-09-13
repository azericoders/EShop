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

        public ActionResult Index()
        {
            return View(new LoginUser());
        }

        [HttpPost]
        public ActionResult Index(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
    }
}


