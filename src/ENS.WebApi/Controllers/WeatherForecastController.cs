using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ENS.WebApi.Controllers
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
        private readonly IUserService _userService;
        private readonly MyClass _myClass;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IUserService userService, MyClass myClass)
        {
            _logger = logger;
            _userService = userService;
            _myClass = myClass;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpGet]
        [Route("test")]
        public string GetStaticName()
        {
            return _userService.GetName();
        }

        [HttpGet]
        [Route("{name}")]
        public string GetCustomName(string name)
        {
            return _myClass.GetMyName(name);
        }
    }
}
