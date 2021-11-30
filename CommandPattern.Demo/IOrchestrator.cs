namespace CommandPattern.Demo
{
    public interface IOrchestrator
    {
        bool CreateOrder(Order order);
    }
}