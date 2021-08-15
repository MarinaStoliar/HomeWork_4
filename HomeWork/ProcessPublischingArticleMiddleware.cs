using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Interfaces;
using ServicesArticles;
using Microsoft.AspNetCore.Builder;

namespace HomeWork
{
    public class ProcessPublischingArticleMiddleware
    {
        private readonly RequestDelegate _requestDelegate;
       
        public ProcessPublischingArticleMiddleware(RequestDelegate requestDelegate, ProcessPublischingArticle processPublischingArticle)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(Interfaces.HttpContext context, ProcessPublischingArticle processPublischingArticle)
        {
            //await context.Response.WriteAsync(processPublischingArticle.processPublischingArticle());
        }

    }
}
