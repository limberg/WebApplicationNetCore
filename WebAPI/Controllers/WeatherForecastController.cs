using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPI.ExceptionsFilter;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        //private readonly ILogger<WeatherForecastController> _logger;

        private readonly ILogger _logger;

        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //}

        public WeatherForecastController(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<WeatherForecastController>();
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            _logger.LogInformation("Get Method !");

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("{city}")]
        public WeatherForecast Get(string city)
        {
            if(!string.Equals(city?.TrimEnd(), "Remond", StringComparison.OrdinalIgnoreCase))
            {
                //throw new ArgumentException(message: $"We don't offer a weather forecast for {city}", paramName: nameof(city));
                HttpResponseException exception = new HttpResponseException();
                exception.Value = $"We don't offer a weather forecast for {city}";
                throw exception;// ($"We don't offer a weather forecast for {city}");
            }

            return Get().First();
        }
    }
}
