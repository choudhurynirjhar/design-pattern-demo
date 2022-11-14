namespace FlyweightPattern.Demo;
public class BmwCar : ICar
{
    public string Color {get; private set;}

    public string Engine {get; private set;}

    public BmwCar(string color, string engine)
    {
        Color = color;
        Engine = engine;
    }

    public void SetLocation(decimal lat, decimal lon)
    {
        Console.WriteLine($"Current location of BMW Car with color: {Color}, Engine: {Engine} is {lat}, {lon}");
    }
}
