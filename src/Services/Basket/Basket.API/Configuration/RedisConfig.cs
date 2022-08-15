using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Basket.API.Configuration
{
    public static class RedisConfig
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddStackExchangeRedisCache(opt => opt.Configuration="localhost:6379");
           
        }
    }
}
