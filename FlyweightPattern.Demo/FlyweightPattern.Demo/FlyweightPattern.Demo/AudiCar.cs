namespace FlyweightPattern.Demo;

public class AudiCar : ICar
{
    public string Color { get; private set; }

    public string Engine { get; private set; }

    public AudiCar(string color, string engine)
    {
        Color = color;
        Engine = engine;
    }

    public void SetLocation(decimal lat, decimal lon)
    {
        Console.WriteLine($"Current location of Audi Car with color: {Color}, Engine: {Engine} is {lat}, {lon}");
    }
}
