using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using WebApiContrib.Core.WebPages;

namespace LightweightSiteSample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddWebPages(new WebPagesOptions { RootViewName = "Index" });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseWebPages();
        }
    }
}
