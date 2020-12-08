using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication;
using WebApplication.Options;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MyConfigServiceCollectionExtensions
    {
        public static IServiceCollection AddMyConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<PositionOptions>(configuration.GetSection(PositionOptions.Position));
            services.Configure<ColorOptions>(configuration.GetSection(ColorOptions.Color));

            return services;
        }
    }
}
