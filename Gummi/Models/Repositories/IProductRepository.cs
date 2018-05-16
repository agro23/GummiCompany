using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Gummi.Models.Repositories
//{
//    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
//    public class IProductRepository
//    {
//        private readonly RequestDelegate _next;

//        public IProductRepository(RequestDelegate next)
//        {
//            _next = next;
//        }

//        public Task Invoke(HttpContext httpContext)
//        {

//            return _next(httpContext);
//        }
//    }

//    // Extension method used to add the middleware to the HTTP request pipeline.
//    public static class IProductRepositoryExtensions
//    {
//        public static IApplicationBuilder UseMiddlewareClassTemplate(this IApplicationBuilder builder)
//        {
//            return builder.UseMiddleware<IProductRepository>();
//        }
//    }
//}



{
    public interface IProductRepository
    {
        //Product Index(Product product);
        IQueryable<Product> Products { get; }
        Product Save(Product product);
        Product Edit(Product product);
        void Remove(Product product);
    }
}
