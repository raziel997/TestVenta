using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSVenta.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            List<WeatherForecast> lst = new List<WeatherForecast>();
            lst.Add(new WeatherForecast() { Id = 5, Name = "Elihu" });
            lst.Add(new WeatherForecast() { Id = 6, Name = "Raziel" });
            lst.Add(new WeatherForecast() { Id = 7, Name = "Solis" });
            lst.Add(new WeatherForecast() { Id = 8, Name = "Cristian" });
            lst.Add(new WeatherForecast() { Id = 9, Name = "Apresal" });
            return lst;
            
        }
    }
}
