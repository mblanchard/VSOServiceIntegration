using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using VSOServiceIntegration.Services.Rest;
using VSOServiceIntegration.Services.Rest.Implementations;
using VSOServiceIntegration.Services.Rest.Interfaces;

namespace VSOServiceIntegration.Web
{
    /// <summary>
    /// Setup IoC container configuration
    /// </summary>
    public static class ContainerConfig
    {
        public static IContainer SetupContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<VSOService>().As<IVSOService>();
            builder.RegisterType<SlackService>().As<ISlackService>();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            var container = builder.Build();

            //Setup MVC Dependency resolver
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            return container;
        }
    }
}