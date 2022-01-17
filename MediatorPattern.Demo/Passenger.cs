namespace MediatorPattern.Demo;

internal interface IPassenger
{
    string Name { get; }
    string Address { get; }
    int Location { get; }

    void Acknowledge(string name);
}

internal class Passenger : IPassenger
{
    private string _name;
    private string _address;
    private int _location;

    public Passenger(string name, string address, int location)
    {
        _name = name;
        _address = address;
        _location = location;
    }
    public string Name => _name;

    public string Address => _address;

    public int Location => _location;

    public void Acknowledge(string name) =>
    Console.WriteLine($"Passenger {Name}, Cab: {name}");
}