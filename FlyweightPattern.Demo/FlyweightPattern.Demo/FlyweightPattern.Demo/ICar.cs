namespace FlyweightPattern.Demo;

public interface ICar
{
    string Color { get; }
    string Engine { get; }

    void SetLocation(decimal lat, decimal lon);
}