using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EShop.Core;
using EShop.Infrastructure;
using EShop.Repository.CategoryManager;
using EShop.Repository.CompanyManager;
using EShop.Repository.MessageManager;
using EShop.Repository.OrderManager;
using EShop.Repository.ProductManager;
using EShop.Repository.ProductPhotoManager;
using EShop.Repository.UserManager;
using EShop.Web.Models;
using EShop.Infrastructure;

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
        private readonly IProductPhotoRepository _productPhotoRepository;

        public AdminController(IUserRepository userRepository,
            IOrderRepository orderRepository,
            IMessageRepository messageRepository,
            IProductRepository productRepository,
            ICategoryRepository categoryRepository,
            ICompanyRepository companyRepository,
            IProductPhotoRepository productPhotoRepository)
        {
            this._userRepository = userRepository;
            this._orderRepository = orderRepository;
            this._messageRepository = messageRepository;
            this._productRepository = productRepository;
            this._categoryRepository = categoryRepository;
            this._companyRepository = companyRepository;
            this._productPhotoRepository = productPhotoRepository;
        }
        //
        // GET: /Admin/

        #region Login
        public ActionResult Login()
        {
            return Session["admin"] == null ? View(new LoginUser()) : View("DashBoard");
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
            var categoryList = new SelectList(_categoryRepository.GetAll().Where(category => category.CategoryId != category.MainCategoryId), "CategoryId", "CategoryName", "Seç");

            ViewData["companyList"] = companyList;
            ViewData["subcategoryList"] = categoryList;
            ViewData["categoryList"] = new SelectList(_categoryRepository.GetAll().Where(category => category.CategoryId == category.MainCategoryId), "CategoryId", "CategoryName", "Seç");
            Session["imageList"] = new List<ImageModel>();
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            var imageList = Session["imageList"] as List<ImageModel>;
            if (ModelState.IsValid && imageList.Count != 0)
            {
                var newProduct = new Product
                    {
                        ProductId = Guid.NewGuid(),
                        CategoryId = product.CategoryId,
                        CompanyId = product.CompanyId,
                        Description = product.Description,
                        Count = product.Count,
                        Price = product.Price,
                        Name = product.Name,
                        PriceOfBuying = product.PriceOfBuying,
                        ProductNumber = product.ProductNumber,
                    };
                _productRepository.Save(newProduct);
                foreach (var image in imageList)
                {
                    var photo = new ProductPhoto
                        {
                            ProductPhotoId = Guid.NewGuid(),
                            ProductId = newProduct.ProductId
                        };

                    var filename = String.Format("{0}_{1}", photo.ProductPhotoId, image.ImageName);
                    var thumbfilename = String.Format("{0}_thumb_{1}", photo.ProductPhotoId, image.ImageName);

                    var path = Path.Combine(Server.MapPath("~/Content/images/admin/ProductImage"), filename);
                    var thumbpath = Path.Combine(Server.MapPath("~/Content/images/admin/ProductImage"), thumbfilename);

                    photo.Photo = filename;


                    Image imagePhotoVert = image.Image;
                    using (var imagePhoto = ImageResize.ScaleByPercent(imagePhotoVert, 70))
                    {
                        imagePhoto.Save(path);
                    }

                    var i = imageList.IndexOf(image);
                    if (i == 0)
                    {
                        using (var thumbimagePhoto = ImageResize.Crop(imagePhotoVert, 70, 70, AnchorPosition.Center))
                        {
                            thumbimagePhoto.Save(thumbpath);
                            photo.ThumbnailPhoto = thumbfilename;
                        }
                    }
                    _productPhotoRepository.Save(photo);
                }
            }
            return View();
        }

        public ActionResult SaveUploadedFile()
        {
            var isSavedSuccessfully = true;

            foreach (string fileName in Request.Files)
            {
                HttpPostedFileBase file = Request.Files[fileName];
                //Save file content goes here
                var list = Session["imageList"] as List<ImageModel>;
                var image = new ImageModel()
                    {
                        Image = Image.FromStream(file.InputStream, true, true),
                        ImageName = file.FileName
                    };
                list.Add(image);
                Session["imageList"] = list;
            }
            if (isSavedSuccessfully)
            {
                return Json(new { Message = "File saved" });
            }
            return Json(new { Message = "Error in saving file" });
        }

        #endregion
        public ActionResult Error404()
        {
            return View();
        }


        //Tests

    }
}


