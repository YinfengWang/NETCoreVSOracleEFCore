using App.BusinessService.IService;
using App.BusinessService.Service;
using App.Core;
using App.Data;
using Autofac;

namespace WebApplication.Autofac
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<OracleDbContext>().As<IDbContext>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterType<AssessDocService>().As<IAssessDocService>();

            base.Load(builder);
        }
    }
}