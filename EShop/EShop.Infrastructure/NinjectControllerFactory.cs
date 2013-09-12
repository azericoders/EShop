using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infrastructure
{
    //public class NinjectControllerFactory : DefaultControllerFactory
    //{
    //    private IKernel ninjectKernel;

    //    public NinjectControllerFactory()
    //    {
    //        ninjectKernel = new StandardKernel();
    //        AddBindings();
    //    }

    //    protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
    //    {

    //        return controllerType == null
    //            ? null
    //            : (IController)ninjectKernel.Get(controllerType);
    //    }

    //    private void AddBindings()
    //    {
    //        ninjectKernel.Bind<ICompanyRepository>().To<CompanyRepository>();
    //        ninjectKernel.Bind<IOptionRepository>().To<OptionRepository>();
    //        ninjectKernel.Bind<IDeviceLineRepository>().To<DeviceLineRepository>();
    //        ninjectKernel.Bind<ICategoryRepository>().To<CategoryRepository>();
    //        ninjectKernel.Bind<IProductRepository>().To<ProductRepository>();
    //    }
    //}
}
