using DEV_005.BS.Contracts;
using Microsoft.AspNetCore.Mvc;
using UI.Model;

namespace UI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherInfoService _weatherInfoService;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(IWeatherInfoService weatherInfoService, ILogger<WeatherForecastController> logger)
        {
            _weatherInfoService = weatherInfoService;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public ActionResult<WeatherForecast> Get()
        {
            var currentWeather = _weatherInfoService.GetWeather();
            return new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = $"{currentWeather.TemperatureC} °C",
                Summary = currentWeather.Summary
            };
        }
    }
}
