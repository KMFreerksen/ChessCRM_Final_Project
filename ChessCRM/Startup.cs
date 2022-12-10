using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ChessCRM.Models;

namespace ChessCRM
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
            //services.AddMemoryCache();
            //services.AddSession();

            services.AddRouting(options => options.LowercaseUrls = true);

            services.AddControllersWithViews();

            services.AddDbContext<AcademyContext>(options => options.UseSqlServer(Configuration.GetConnectionString("AcademyContext")));

            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AcademyContext>().AddDefaultTokenProviders();
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
                //app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            //app.UseSession();

            app.UseEndpoints(endpoints =>
            { 
                endpoints.MapAreaControllerRoute(
                      name: "admin",
                      areaName: "Admin",
                      pattern: "Admin/{controller=User}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "updateskill",
                    pattern: "{controller=Home}/{action=UpdateSkill}/{sID}");

                endpoints.MapControllerRoute(
                    name: "Enrollment",
                    pattern: "{controller=Home}/{action=GetCurrentEnrollment}/{id}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            AcademyContext.CreateAdminUser(app.ApplicationServices).Wait();
            AcademyContext.CreateViewOnlyUser(app.ApplicationServices).Wait();
        }
    }
}
