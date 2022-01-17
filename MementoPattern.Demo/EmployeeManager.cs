namespace MementoPattern.Demo;

internal interface IEmployeeManager
{
    void AddMemento(int id,Memento memento);
    Memento GetMemento(int id);
}

internal class EmployeeManager : IEmployeeManager
{
    private readonly Dictionary<int, Stack<Memento>> mementos = new Dictionary<int, Stack<Memento>>();

    public void AddMemento(int id, Memento memento) 
    {
        if (!mementos.ContainsKey(id)) mementos.Add(id, new Stack<Memento>());
        mementos[id].Push(memento); 
    }

    public Memento GetMemento(int id) => mementos[id].Pop();
}