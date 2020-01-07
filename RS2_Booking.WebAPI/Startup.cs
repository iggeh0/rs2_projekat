using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using AutoMapper;
using RS2_Booking.WebAPI.Services;
using Microsoft.EntityFrameworkCore;
using RS2_Booking.WebAPI.Models;
using RS2_Booking.WebAPI.Filters;
using RS2_Booking.Model;
using RS2_Booking.Model.Requests;
using Microsoft.AspNetCore.Authentication;
using RS2_Booking.WebAPI.Security;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace RS2_Booking.WebAPI
{
        public class BasicAuthDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            var securityRequirements = new Dictionary<string, IEnumerable<string>>()
        {
            { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
        };

            swaggerDoc.Security = new[] { securityRequirements };
        }
    }

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


            services.AddMvc(x=> x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddAutoMapper();
            var connection = @"Server=localhost;Database=IB130107;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<Online_BookingContext>(options => options.UseSqlServer(connection));


            services.AddAuthentication("BasicAuthentication")
               .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();
            });
            services.AddScoped<IService<InventarModel, InventarSearchRequest, InventarInsertRequest>, InventarService>();
            services.AddScoped<IService<SobaModel, SobaSearchRequest, SobaInsertRequest>, SobaService>();
            services.AddScoped<ISmjestajService, SmjestajService>();
            services.AddScoped<IKorisnikService, KorisnikService>(); 
            services.AddScoped<IService<GradModel, object, GradModel>, BaseService<GradModel, object, GradModel, Grad>>();
            services.AddScoped<IOkolinaService, OkolinaService>();
            services.AddScoped<IUslugaService, UslugaService>();
        }

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

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseAuthentication();

            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }

}
