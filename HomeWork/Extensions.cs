using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Interfaces;
using Microsoft.Extensions.DependencyInjection;
using ServicesArticles;

namespace HomeWork
{
    public static class Extensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddSingleton<ISeveInformationAboutArticle, SeveInformationAboutArticle>();
            services.AddSingleton<IAddContentInArticle, AddContentInArticle>();
            services.AddTransient<ICheckArticleOnErrors, CheckArticleOnErrors>();
            services.AddScoped<IPublishArticle, PublishArticle>();
            services.AddScoped<IProcessPublischingArticle, ProcessPublischingArticle>();
            

            return services;
        }
    }
}