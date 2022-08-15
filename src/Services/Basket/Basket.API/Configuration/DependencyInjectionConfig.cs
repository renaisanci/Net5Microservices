
using Basket.API.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Basket.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IBasketRepository, BasketRepository>();
       
           
        }
    }
}
