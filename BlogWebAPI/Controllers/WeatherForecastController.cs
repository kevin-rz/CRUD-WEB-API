using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlogWebAPI.Models;
using BlogWebAPI.Services;
using BlogWebAPI.Repositories;

namespace BlogWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        /*
        private WeatherForecastService _weatherForecastService;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, WeatherForecastService weatherForecastService) 
        {
            _weatherForecastService = weatherForecastService;
            _logger = logger;
        }

        [HttpGet]
        public IList<string> Get()
        {
            _logger.LogInformation(DateTime.Now.ToString());
            return _weatherForecastService.GetSummaries();
        }

        [HttpPost]
        public WeatherForecastModel Post([FromBody]WeatherForecastModel weatherForecast)
        {
            var weatherForecastList = _weatherForecastService.GetSummaries();
            weatherForecastList.Add(weatherForecast.Summary);
            return weatherForecast;
        }

        [HttpPut]
        [Route("actualizaunaparte")]
        public WeatherForecastModel Put([FromBody]WeatherForecastModel weatherForecast) 
        { 
            return weatherForecast;
        }
        */
    }
}
