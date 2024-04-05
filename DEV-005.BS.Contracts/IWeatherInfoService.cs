using DEV_005.BS.Contracts.DTO;

namespace DEV_005.BS.Contracts;

public interface IWeatherInfoService
{
    WeatherCondition GetWeather();
}