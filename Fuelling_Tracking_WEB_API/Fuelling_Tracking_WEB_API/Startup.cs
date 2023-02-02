

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fuelling_Tracking_WEB_API
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

            //services.AddDbContext<FuelDbContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("DevConnection")));

            services.AddCors(option=>
            {
                option.AddPolicy(name:"AllowOrigin",builder =>
                {
                    builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
                });
            });


            services.AddAuthentication("JWTAuth")
                 .AddJwtBearer("JWTAuth", options =>
                 {

                     var keyBytes = Encoding.UTF8.GetBytes(Constants.Secret);

                     var key = new SymmetricSecurityKey(keyBytes);

                     options.TokenValidationParameters = new TokenValidationParameters()
                     {
                         ValidIssuer = Constants.Issuer,
                         ValidAudience = Constants.Audience,
                         IssuerSigningKey = key,

                     };


                 });

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Fuelling_Tracking_WEB_API", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Fuelling_Tracking_WEB_API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("AllowOrigin");
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
