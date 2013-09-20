using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EShop.Core;
using EShop.Repository.CategoryManager;
using EShop.Repository.CompanyManager;
using EShop.Repository.MessageManager;
using EShop.Repository.OrderManager;
using EShop.Repository.ProductManager;
using EShop.Repository.UserManager;
using EShop.Web.Models;

namespace EShop.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IMessageRepository _messageRepository;
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICompanyRepository _companyRepository;

        public AdminController(IUserRepository userRepository,
            IOrderRepository orderRepository,
            IMessageRepository messageRepository,
            IProductRepository productRepository,
            ICategoryRepository categoryRepository,
            ICompanyRepository companyRepository)
        {
            this._userRepository = userRepository;
            this._orderRepository = orderRepository;
            this._messageRepository = messageRepository;
            this._productRepository = productRepository;
            this._categoryRepository = categoryRepository;
            this._companyRepository = companyRepository;
        }
        //
        // GET: /Admin/

        #region Login
        public ActionResult Login()
        {
            return View(new LoginUser());
        }

        [HttpPost]
        public ActionResult Login(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                var dtUser = _userRepository.GetUserByNameAndPassword(user.UserName, user.Password);
                if (dtUser != null)
                {
                    Session["admin"] = _userRepository.GetById(dtUser.UserId);
                    return RedirectToActionPermanent("DashBoard");
                }
            }
            return View();
        }

        #endregion

        public ActionResult DashBoard()
        {
            return Session["admin"] == null ? View("Login") : View();
        }
        #region User
        [HttpGet]
        public new ActionResult User()
        {
            if (Session["admin"] != null)
            {
                var users = _userRepository.GetAll();
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
        public ActionResult DeleteUser(User user)
        {
            _userRepository.DeleteById(user.UserId);
            return RedirectToActionPermanent("User");
        }

        [HttpGet]
        public ActionResult CreateUser()
        {
            return Session["admin"] == null ? View("Login") : View("User");
        }

        [HttpPost]
        public ActionResult CreateUser(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                    {
                        LoginName = model.LoginName,
                        Email = model.Email,
                        Password = model.Password,
                    };
                _userRepository.Save(user);
                RedirectToActionPermanent("User");
            }
            return View();
        }
        #endregion

        #region Messages

        [HttpGet]
        public ActionResult Message()
        {
            return Session["admin"] == null ? View("Login") : View(_messageRepository.GetAll().Where(message => message.IsDelete == false));
        }

        [HttpPost]
        public ActionResult DeleteMessage(Guid messageId)
        {
            _messageRepository.DeleteById(messageId);
            return View("Message");
        }

        #endregion

        #region Order
        public ActionResult Order()
        {

            return Session["admin"] == null ? View("Login") : View(_orderRepository.GetAll());
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

        #region Product
        public ActionResult Product()
        {
            return Session["admin"] == null ? View("Login") : View();
        }

        public ActionResult CreateProduct()
        {
            if (Session["admin"] == null)
            {
                return View("Login");
            }

            var companyList = new SelectList(_companyRepository.GetAll(), "CompanyId", "CategoryName");
            var categoryList = new SelectList(_categoryRepository.GetAll().Where(category => category.CategoryId != category.MainCategoryId), "CategoryId", "CategoryName");

            ViewData["companyList"] = companyList;
            ViewData["subcategoryList"] = categoryList;
            ViewData["categoryList"] = new SelectList(_categoryRepository.GetAll().Where(category => category.CategoryId == category.MainCategoryId), "CategoryId", "CategoryName");
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.Save(product);
            }
            return View();
        }

        #endregion
        public ActionResult Error404()
        {
            return View();
        }


        //Tests

    }
}


