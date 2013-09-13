using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using EShop.Repository.CategoryManager;
using EShop.Repository.CompanyManager;
using EShop.Repository.OrderLineManager;
using EShop.Repository.OrderManager;
using EShop.Repository.ProductManager;
using EShop.Repository.UserManager;
using Ninject;
using System.Web.Mvc;

namespace EShop.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {

            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);
        }

        //<Summary>
        // inject Repository classes to interfaces
        //</Summary>
        private void AddBindings()
        {

            ninjectKernel.Bind<ICategoryRepository>().To<CategoryRepository>();
            ninjectKernel.Bind<ICompanyRepository>().To<CompanyRepository>();
            ninjectKernel.Bind<IOrderRepository>().To<OrderRepository>();
            ninjectKernel.Bind<IOrderLineRepository>().To<OrderLineRepository>();
            ninjectKernel.Bind<IProductRepository>().To<ProductRepository>();
            ninjectKernel.Bind<IUserRepository>().To<UserRepository>();
        }
    }
}
