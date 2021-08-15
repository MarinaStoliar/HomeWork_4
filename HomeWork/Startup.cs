using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;
using ServicesArticles;
using Microsoft.AspNetCore.Http;



namespace HomeWork
{
    public class Startup
    {
        public Startup()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("person.json");
            AppConfiguration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        public IConfiguration AppConfiguration { get; set; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddServices();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HomeWork_2", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseMiddleware<ProcessPublischingArticleMiddleware>();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HomeWork_2 v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            var tom = new MyPersonConfiguration();
            AppConfiguration.Bind(tom);

            app.Run(async (context) =>
            {
                string name = $"<p>Name: {tom.Name}</p>";
                string age = $"<p>Age: {tom.Age}</p>";
                string company = $"<p>Company: {tom.Company?.Title}</p>";
                string langs = "<p>Languages:</p><ul>";
                foreach (var lang in tom.Languages)
                {
                    langs += $"<li><p>{lang}</p></li>";
                }
                langs += "</ul>";

                await context.Response.WriteAsync($"{name}{age}{company}{langs}");
            });

        }


    }
}
