using Autofac;
using System.Reflection;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using SampleProject.SampleServices;
using SampleProject.SampleServices.Abstraction;

namespace SampleProject
{
    public static class DependencyRegistrar
    {
        public static void RegisterAllClass()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<Service1>().As<IService1>();
            builder.RegisterType<Service2>().As<IService2>();
            builder.RegisterType<Service3>().As<IService3>();


            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}