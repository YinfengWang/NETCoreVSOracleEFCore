using System;
using App.Data;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication.Autofac;

namespace WebApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public ILifetimeScope AutofacContainer { get; private set; }
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            //services.AddDbContext<OracleDbContext>(options => { options.UseOracle(Configuration.GetConnectionString("OracleContext")); });

            services.AddDbContextPool<OracleDbContext>(options =>
            {
                options.UseOracle(Configuration.GetConnectionString("OracleContext"), b => b.UseOracleSQLCompatibility("11"));// 这是错误的写法，默认是12g版本的语法
            });


            // Add Autofac
            // create a container-builder and register dependencies
            var builder = new ContainerBuilder();
            // populate the service-descriptors added to `IServiceCollection`
            // BEFORE you add things to Autofac so that the Autofac
            // registrations can override stuff in the `IServiceCollection`
            // as needed
            builder.RegisterModule(new AutofacModule());
            builder.Populate(services);

            AutofacContainer = builder.Build();
            // this will be used as the service-provider for the application!
            return new AutofacServiceProvider(AutofacContainer);
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        //    services.AddEntityFrameworkOracle();
        //    //
        // //   services.AddDbContext<OracleDbContext>(options => { options.UseOracle(Configuration.GetConnectionString("OracleContext")); });
        //}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
