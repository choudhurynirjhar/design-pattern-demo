namespace MediatorPattern.Demo;

internal interface ICab
{
    string Name { get; }
    int CurrentLocation { get; }
    bool IsFree { get; }

    void Assign(string name, string address);
}

internal class Cab : ICab
{
    private readonly string _name;
    private readonly int _location;
    private readonly bool _free;

    public Cab(string name, int location, bool free)
    {
        _name = name;
        _location = location;
        _free = free;
    }

    public string Name => _name;

    public int CurrentLocation => _location;

    public bool IsFree => _free;

    public void Assign(string name, string address) =>
        Console.WriteLine($"Cab {Name}, assigned to passenger: {name}, {address}");
}
