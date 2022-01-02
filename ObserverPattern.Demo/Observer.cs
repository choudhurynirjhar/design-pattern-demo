namespace ObserverPattern.Demo;
internal class Observer : IObserver<User>
{
    public void OnCompleted()
    {
        Console.WriteLine("Completed");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine("Error");
    }

    public void OnNext(User value)
    {
        Console.WriteLine($"Name: {value.Name}, Age: {value.Age}");
    }
}
