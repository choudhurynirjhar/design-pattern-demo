namespace DecoratorPattern.Demo;
public class CakeMessageDecorator 
    : ICakeMessageDecorator
{
    private readonly ICake cake;

    public CakeMessageDecorator(ICake cake)
    {
        this.cake = cake;
    }

    public void Decorate(string message)
    {
        cake.AddLayer($"Message for the cake: {message}");    
    }
}