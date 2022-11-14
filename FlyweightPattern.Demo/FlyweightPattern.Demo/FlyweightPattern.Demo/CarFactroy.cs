namespace FlyweightPattern.Demo;

public interface ICarFactroy
{
    ICar GetCar(string type);
}

public class CarFactroy : ICarFactroy
{
    private readonly IDictionary<string, ICar> cars = new Dictionary<string, ICar>();

    public ICar GetCar(string type)
    {
        if (cars.ContainsKey(type)) return cars[type];
        var car = CreateCar(type);
        cars.Add(type, car);
        return car;
    }

    private ICar CreateCar(string type) =>
        type switch
        {
            "Bmw" => new BmwCar("V8", "Red"),
            "Audi" => new AudiCar("V6", "Blue"),
            _ => throw new ArgumentException("Invalid Choice")
        };
}