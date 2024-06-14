using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Arlanet.Optimizely.ProductMarkets.Middleware
{
    public static class PluginMiddleware
    {
        public static IServiceCollection AddProductMarkets(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(ProductMarketsMenuProvider).GetTypeInfo().Assembly;

            services.AddControllersWithViews()
                .AddApplicationPart(assembly)
                .AddRazorRuntimeCompilation();      // Add package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation

            var fileProvider = new MyEmbeddedFileProvider(assembly);

            services.Configure<MvcRazorRuntimeCompilationOptions>(options =>
            {
                options.FileProviders.Add(fileProvider);
            });

            return services;
        }
    }
}
