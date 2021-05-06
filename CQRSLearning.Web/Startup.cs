
using CQRSLearning.Web.Data;
using CQRSLearning.Web.UseCases.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSLearning.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<FakeDbContext>();

            #region for CQRS without Any Library
            //var resultCommandHandlers = typeof(Startup).Assembly.GetTypes().Where(c=>c.GetInterfaces().Any(d=>d.IsGenericType==true&&d.GetGenericTypeDefinition()== typeof(ICommandHandler<>)));
            //var resultQueryHandlersWithInput = typeof(Startup).Assembly.GetTypes().Where(c => c.GetInterfaces().Any(d => d.IsGenericType == true && d.GetGenericTypeDefinition() == typeof(IQueryHandler<,>)));
            //var resultQueryHandlersWithOutInput = typeof(Startup).Assembly.GetTypes().Where(c => c.GetInterfaces().Any(d => d.IsGenericType == true && d.GetGenericTypeDefinition() == typeof(IQueryHandler<>)));
            //foreach (var command in resultCommandHandlers)
            //{
            //    services.AddScoped(command);
            //}
            //foreach (var command in resultQueryHandlersWithInput)
            //{
            //    services.AddScoped(command);
            //}
            //foreach (var command in resultQueryHandlersWithOutInput)
            //{
            //    services.AddScoped(command);
            //}
            #endregion

            services.AddMediatR(typeof(Startup));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
