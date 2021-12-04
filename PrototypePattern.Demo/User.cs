namespace PrototypePattern.Demo;

public interface IUser : ICloneable
{
    string Name { get; }
    string Address { get; }
    int Age { set; }
}

public class User : IUser
{
    private string name;
    private int age;
    private string address;

    public User(string name, string address)
    {
        this.name = name;
        this.address = address;
    }

    public string Name => name;

    public string Address => address;

    public string Details => $"User : {name}, Age: {age}, Address: {address}";

    public int Age
    {
        set { age = value; }
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}