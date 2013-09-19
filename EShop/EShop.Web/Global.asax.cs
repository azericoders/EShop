using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using EShop.Core;
using EShop.CoreAccess;
using EShop.Infrastructure;

namespace EShop.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EShopDbContext>());

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());

            using (var context = new EShopDbContext())
            {
                
                    var ur = context.Users.Count();
                    if (ur == 0)
                    {

                        var user1 = new User()
                            {
                                LoginName = "Elvin",
                                Password = "123",
                                Email = "elvin.arzumanoglu@gmail.com",
                                Position = PositionEnum.Admin,
                                Status = StatusEnum.Active
                            };
                        var user2 = new User()
                            {
                                LoginName = "Zamir",
                                Password = "123",
                                Email = "zamirmmmm@gmail.com",
                                Position = PositionEnum.Admin,
                                Status = StatusEnum.Active
                            };
                        context.Users.Add(user1);
                        context.Users.Add(user2);
                        context.SaveChanges();
                    
                }
            }
        }
    }
}