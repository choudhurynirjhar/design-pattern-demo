namespace FlyweightPattern.Demo;

public interface ICarManager
{
    void SetLocation(decimal lat, decimal lon);
}

public class CarManager : ICarManager
{
    private readonly ICar car;

    public CarManager(ICarFactroy carFactroy, string type)
    {
        car = carFactroy.GetCar(type);
    }

    public void SetLocation(decimal lat, decimal lon)
    {
        car.SetLocation(lat, lon);
    }
}