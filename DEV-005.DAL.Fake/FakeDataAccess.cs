using DEV_005.DAL.Contracts;

namespace DEV_005.DAL.Fake;

public class FakeDataAccess : IRepository
{
    public int GetTemperatureC()
    {
        return 26;
    }

    public decimal GetPressure()
    {
        return 786;
    }

    public int GetHumidity()
    {
        return 80;
    }
}