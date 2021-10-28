using Autofac;
using Autofac.Integration.WebApi;
using SolutionEF.Core.Services;
using SolutionEF.Infra.Context;
using SolutionEF.Infra.Repositories;
using SolutionEF.ServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace SolutionEFApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //GlobalConfiguration.Configure(WebApiConfig.Register);

            var builder = new ContainerBuilder();
            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            // OPTIONAL: Register the Autofac model binder provider.
            builder.RegisterWebApiModelBinderProvider();

            // Set the dependency resolver to be Autofac.
            builder.RegisterType<SolutionEFContext>();

            builder.RegisterType<BookRepository>().As<IBookRepository>();

            builder.RegisterType<BookService>().As<IBookService>();

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
