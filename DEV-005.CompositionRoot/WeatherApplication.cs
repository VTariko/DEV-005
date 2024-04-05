using DEV_005.BS;
using DEV_005.BS.Contracts;
using DEV_005.DAL.Contracts;
using DEV_005.DAL.Fake;
using Microsoft.Extensions.DependencyInjection;

namespace DEV_005.CompositionRoot;

public class WeatherApplication : ApplicationLayerBuilder
{
    public WeatherApplication(IServiceCollection services) : base(services)
    {
    }

    protected override void RegisterBusinessService()
    {
        Services.AddTransient<IWeatherInfoService, WeatherInfoService>();
    }

    protected override void RegisterDataAccessLayer()
    {
        Services.AddTransient<IRepository, FakeDataAccess>();
    }
}