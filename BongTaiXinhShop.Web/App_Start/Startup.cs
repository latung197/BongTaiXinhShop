using System;
using System.Threading.Tasks;
using Autofac;
using Microsoft.Owin;
using Owin;
using BongTaiXinhShop.Model.Model;
using BongTaiXinhShop.Model.Abstract;
using BongTaiXinhShop.Data.Repositorys;
using BongTaiXinhShop.Data.Infastructure;
using BongTaiXinhShop.Data;
using BongTaiXinhShop.Service;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;

[assembly: OwinStartup(typeof(BongTaiXinhShop.Web.App_Start.Startup))]

namespace BongTaiXinhShop.Web.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigAutofac(app);
        }

        private void ConfigAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            //  RegisterApiControllers web API
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UnitOfwork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterType<BongTaiXinhShopDbContext>().AsSelf().InstancePerRequest();

            // Reposotories
            builder.RegisterAssemblyTypes(typeof(PostCategoryRepository).Assembly).Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerRequest();            
            
            // services
            builder.RegisterAssemblyTypes(typeof(PostCategoryService).Assembly).Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerRequest();

            Autofac.IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);


        }
    }
}
