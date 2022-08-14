using Catalog.API.Data;
using Catalog.API.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ICatalogContext, CatalogContext>();
            services.AddScoped<IProductRepository, ProductRepository>();
           
        }
    }
}
