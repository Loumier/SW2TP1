using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWTP01
{
    class Program
    {
        static void Main(string[] args)
        {         
            IWebHost host = new WebHostBuilder().UseKestrel().UseStartup<Startup>().Build();
            host.Run();
        }

        public class Startup{
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddRouting();
            }

            public void Configure(IApplicationBuilder app){
               
                var builder = new RouteBuilder(app);
                builder.MapRoute("/nameBook", NameBook);
                builder.MapRoute("/resultToString", resultToString);
                builder.MapRoute("/getAuthorNames", getAuthorNames);               
                builder.MapRoute("/book/showBook", sendHTML);
                var route = builder.Build();
                app.UseRouter(route);
            }

            public Task NameBook(HttpContext context)
            {
                bookController bookC = new bookController();
                var book = bookC.searchBook();
                return context.Response.WriteAsync(book[0].name);
            }
            public Task resultToString(HttpContext context)
            {
                bookController bookC = new bookController();
                var book = bookC.searchBook();
                return context.Response.WriteAsync(book[0].ToString());
            }

            public Task getAuthorNames(HttpContext context)
            {
                bookController bookC = new bookController();
                var book = bookC.searchBook();
                return context.Response.WriteAsync(book[0].getAuthorNames());
            }

            public Task sendHTML(HttpContext context)
            {
                bookController bookC = new bookController();
                var book = bookC.searchBook();
                var html = $"<pre style='color:blue'>{book[0].ToString()}</pre>";
                return context.Response.WriteAsync(html);
            }
        }
    }
}
