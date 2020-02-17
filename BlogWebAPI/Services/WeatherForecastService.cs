using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogWebAPI.Repositories;

namespace BlogWebAPI.Services
{
    public class WeatherForecastService
    {
        private WeatherForecastRepository _weatherForecastRepository;

        public WeatherForecastService(WeatherForecastRepository weatherForecastRepository)
        {
            _weatherForecastRepository = weatherForecastRepository;
        }

        public List<string> GetSummaries() 
        {
            return _weatherForecastRepository.GetSummaries();
        }
    }
}
