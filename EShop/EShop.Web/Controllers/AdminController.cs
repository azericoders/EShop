using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EShop.Core;
using EShop.Repository.UserManager;
using EShop.Web.Models;

namespace EShop.Web.Controllers
{
    public class AdminController : Controller
    {
        private IUserRepository userRepository;

        public AdminController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
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
                var dtUser = userRepository.GetUserByNameAndPassword(user.UserName, user.Password);
                if (dtUser != null)
                {
                    Session["admin"] = userRepository.GetById(dtUser.UserId);
                    return RedirectToActionPermanent("DashBoard");
                }
            }
            return View();
        }

        public ActionResult DashBoard()
        {
            return Session["admin"] == null ? View("Login") : View();
        }

        #region User
        [HttpGet]
        public ActionResult User()
        {
            if (Session["admin"] != null)
            {
                var users = userRepository.GetAll();
                return View(users);
            }
            return View("Login");
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

        [HttpGet]
        public ActionResult CreateNew()
        {
            return Session["admin"] == null ? View("Login") : View();
        }

        [HttpPost]
        public ActionResult CreateNew(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                    {
                        LoginName = model.LoginName,
                        Email = model.Email,
                        Password = model.Password,
                    };
                userRepository.Save(user);
            }
            return View();
        }
        #endregion

        #region Messages

        [HttpGet]
        public ActionResult Message()
        {
            return   Session["admin"] == null ? View("Login") : View();
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
            return   Session["admin"] == null ? View("Login") : View();
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
            return  Session["admin"] == null ? View("Login") : View();
        }
        public ActionResult Error404()
        {
            return View();
        }


        //Tests

    }
}


