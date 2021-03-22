using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web.Mvc;
using UIB.Models;
using UIB.Models.Interface;
using UIB.Models.Repository;

namespace UIB
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
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppDbContext>(options=>options.UseSqlServer(connection));
            services.AddControllersWithViews(MvcOptions=>MvcOptions.EnableEndpointRouting=false);
            services.AddTransient<ISubjectRep, EFSubjectRep>();
            services.AddTransient<IUserRep, EFUserRep>();
            services.AddTransient<IUnitRep, EFUnitRep>();

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseMvc(routes =>
            {
               
                routes.MapRoute(
                    
                    name: null,
                    template: "{category}",
                    defaults: new { controller = "Subject", action = "List",id="category" }
                    );
                routes.MapRoute(
                    name:"default",
                    template: "{controller=Home}/{action=Index}/"
                    );

            }
            

            ) ;
         
        }
    }
}
