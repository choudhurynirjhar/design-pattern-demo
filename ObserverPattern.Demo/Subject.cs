namespace ObserverPattern.Demo;

internal interface ISubject
{
    event Action<User> UserChanged;

    void UpdateUserAge(int age);
}

internal class Subject : IObservable<User>, IDisposable
{
    private readonly User user;
    private IList<IObserver<User>> observers = new List<IObserver<User>>();

    public Subject(string name, int age)
    {
        user = new User { Name = name, Age = age };
    }

    public void Dispose()
    {
        observers.Clear();
    }

    public IDisposable Subscribe(IObserver<User> observer)
    {
        this.observers.Add(observer);
        observer.OnNext(user);
        return this;
    }

    public void UpdateUserAge(int age)
    {
        user.Age = age;
        foreach (var observer in observers)
        {
            observer.OnNext(user);
        }
    }
}