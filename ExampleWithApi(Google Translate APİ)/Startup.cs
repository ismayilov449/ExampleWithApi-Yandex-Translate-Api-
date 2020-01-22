using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleWithApi_Google_Translate_APİ_.Repository.Abstract;
using ExampleWithApi_Google_Translate_APİ_.Repository.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ExampleWithApi_Google_Translate_APİ_
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ProductsDbContext>(options =>
          options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ProductsDb;Trusted_Connection=True;MultipleActiveResultSets=true"));

            services.AddTransient<IProductRepository, EfProductRepository>();

            services.AddTransient<IUnitOfWork, EfUnitOfWork>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseStatusCodePages();


            app.UseMvc(routes =>
            {
  
                routes.MapRoute(
                     name: "default",
                     template: "{controller}/{action}/{id?}",
                     defaults: new { controller = "Home", action = "ProductsList" }
                     );
              
            });
        }
    }
}
