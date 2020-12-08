using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;

namespace Microsoft.Extensions.DependencyInjection.WebApplication.Options
{
    public interface IMyDependency
    {
        void WriteMessage(string message);
    }

    public class MyDependency : IMyDependency
    {
        private readonly ILogger<MyDependency> _logger;

        public MyDependency(ILogger<MyDependency> logger)
        {
            _logger = logger;
        }

        public void WriteMessage(string message)
        {
            _logger.LogInformation(
                $"MyDependency.WriteMessage called. Message: {message}");
        }
    }
    public interface IMyDependency2
    {
        void WriteMessage(string message);
    }

    public class MyDependency2 : IMyDependency2
    {
        private readonly ILogger<MyDependency2> _logger;

        public MyDependency2(ILogger<MyDependency2> logger)
        {
            _logger = logger;
        }

        public void WriteMessage(string message)
        {
            _logger.LogInformation(
                $"MyDependency2.WriteMessage called. Message: {message}");
        }
    }

    public static class MyDependencyServiceCollectionExtensions
    {
        public static IServiceCollection AddMyDependencyGroup(this IServiceCollection services)
        {
            services.AddScoped<IMyDependency, MyDependency>();
            services.AddScoped<IMyDependency2, MyDependency2>();
            return services;
        }
    }
}

