using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Basket.API.Configuration
{
    public static class RedisConfig
    {
        public static void AddRedisCache(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddStackExchangeRedisCache(opt => opt.Configuration= configuration.GetValue<string>("CachingSettings:ConnectionString"));           
        }
    }
}

