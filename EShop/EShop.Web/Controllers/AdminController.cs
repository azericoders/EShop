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


        #region User
        [HttpGet]
        public ActionResult User()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditUser()
        {
            return View("User");
        }

        [HttpPost]
        public ActionResult DeleteUser()
        {
            return View("User");
        }
        #endregion

        #region Messages

        [HttpGet]
        public ActionResult Message()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteMessage()
        {
            return View("Message");
        }

        #endregion
        #region Order
        public ActionResult Order()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChangeOrderStatus(OrderStatusViewModel model)
        {

            return View("Order");
        }

        [HttpPost]
        public ActionResult DeleteOrder()
        {
            return View("Order");
        }
        #endregion
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Error404()
        {
            return View();
        }


        //Tests
      
    }
}


