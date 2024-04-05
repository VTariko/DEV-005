using DEV_005.BS.Contracts;
using DEV_005.BS.Contracts.DTO;
using DEV_005.DAL.Contracts;

namespace DEV_005.BS;

public class WeatherInfoService : IWeatherInfoService
{
    private readonly IRepository _repository;

    public WeatherInfoService(IRepository repository)
    {
        _repository = repository;
    }

    public WeatherCondition GetWeather()
    {
        var temperature = _repository.GetTemperatureC();
        var humidity = _repository.GetHumidity();

        var summary = $"Сегодня у нас {(temperature > 25 ? "очень жарко" : "комфортная температура")}, " +
                         $"{(humidity > 90 ? "высокая влажность" : "комфортная влажность")}";

        return new WeatherCondition
        {
            TemperatureC = temperature,
            Humidity = humidity,
            Pressure = _repository.GetPressure(),
            Summary = summary
        };
    }
}