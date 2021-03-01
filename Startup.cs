using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Resume.Data;

namespace Resume
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
            services.AddControllersWithViews();
            services.AddRazorPages()
                .AddRazorRuntimeCompilation();
            services.AddAntiforgery(o => o.HeaderName = "Resume-TOKEN");

            services.AddDbContext<ConspectusContext>(options =>
                    options.UseSqlite(Configuration.GetConnectionString("ConspectusContext")));

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
            app.Use(async (context, next) =>
            {
                var url = context.Request.Path.Value;

                // Rewrite to index
                if (url.Contains("/hm/"))
                {
                    var slug = url.Split('/');

                    if (slug[2] != null)
                    {
                        // rewrite and continue processing: Below is the matching url:
                        // /hm/slug-to-match
                        // <a asp-controller="hm" asp-action="@item.ResumeSlug"><i class="bi bi-file-text"></i> </a>
                        context.Request.Path = "/hm/index/" + slug[2];
                    }

                }

                await next();
            });
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapAreaControllerRoute(
                    areaName: "areas",
                    name: "areas",
                    pattern: "{area:exists}/{Controller=Default}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                        name: "conspectus",
                    pattern: "{controller=Conspectus}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                        name: "hm",
                     
                    pattern: "{controller=hm}/{action=Index}/{id?}");
                  
            });
        }
    }
}
