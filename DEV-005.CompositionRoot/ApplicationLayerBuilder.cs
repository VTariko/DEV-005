using Microsoft.Extensions.DependencyInjection;

namespace DEV_005.CompositionRoot;

public abstract class ApplicationLayerBuilder
{
    protected readonly IServiceCollection Services;
    
    protected ApplicationLayerBuilder(IServiceCollection services)
    {
        Services = services;
    }

    protected abstract void RegisterBusinessService();
    protected abstract void RegisterDataAccessLayer();

    public void Build()
    {
        RegisterDataAccessLayer();
        RegisterBusinessService();
    }
}