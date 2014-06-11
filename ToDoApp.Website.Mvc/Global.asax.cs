using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using StructureMap;
using ToDoApp.Website.DependencyResolution;

namespace ToDoApp.Website.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.CreateMappings();

            ObjectFactory.Initialize(i => i.AddRegistry<ResolutionConfiguration>());
            ControllerBuilder.Current.SetControllerFactory(new StructureMapControllerFactory());
        }
    }
}
