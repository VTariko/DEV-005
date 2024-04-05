namespace DEV_005.DAL.Contracts;

public interface IRepository
{
    int GetTemperatureC();
    decimal GetPressure();
    int GetHumidity();
}