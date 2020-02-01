using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DMR.WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Environment = env;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddControllers();

            //if (Environment.IsDevelopment())
            //{
            //    services.AddDbContext<RazorPagesMovieContext>(options =>
            //        options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
            //}
            //else
            //{
            //    services.AddDbContext<RazorPagesMovieContext>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //}

            // Add OpenAPI document with custom, arbitrary generator settings
            services.AddOpenApiDocument(config =>
            {
                config.PostProcess = document =>
                {
                    document.Info.Version = "v1"; // Version of app API, not OpenAPI
                    document.Info.Title = "Movie API";
                    document.Info.Description = "A simple ASP.NET Core web API";
                    document.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = "YourName",
                        Email = string.Empty,
                        Url = "https://twitter.com/YourName"
                    };
                    document.Info.License = new NSwag.OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = "https://example.com/license"
                    };
                    document.Info.TermsOfService = "None";
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseDatabaseErrorPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });

            // Generate OpenAPI from Core API Explorer; Add ReDoc UI to pipeline
            app.UseOpenApi();
            app.UseReDoc(config =>
            {
                config.Path = "/redoc";
                config.DocumentPath = "/swagger/v1/swagger.json";
            });
        }
    }
}
