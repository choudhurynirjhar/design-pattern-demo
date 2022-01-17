namespace MementoPattern.Demo;

internal record Memento(int Id, string Name, int Age, string Phone);

internal interface IEmployee
{
    int Id { get; }
    int Age { get; set; }
    string Name { get; set; }
    string Phone { get; set; }

    Memento Create();
    void Undo(Memento memento);
}

internal class Employee : IEmployee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Phone { get; set; }

    public Memento Create() => new Memento(Id, Name, Age, Phone);

    public void Undo(Memento memento)
    {
        Id = memento.Id;
        Name = memento.Name;
        Age = memento.Age;
        Phone = memento.Phone;
    }
}