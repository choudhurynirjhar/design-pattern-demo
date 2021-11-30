namespace CommandPattern.Demo;

public interface IMessage { }

public interface ICommand
{
    bool Execute(IMessage message);
    bool Rollback(IMessage message);
}

public class OrderCommand : ICommand
{
    private readonly IProxy<Order> orderProxy;

    public OrderCommand(IProxy<Order> orderProxy)
    {
        this.orderProxy = orderProxy;
    }

    public bool Execute(IMessage message)
    {
        return orderProxy.Create((Order)message);
    }

    public bool Rollback(IMessage message)
    {
        return orderProxy.Delete((Order)message);
    }
}

public class InventoryCommand : ICommand
{
    private readonly IProxy<Inventory> orderProxy;

    public InventoryCommand(IProxy<Inventory> orderProxy)
    {
        this.orderProxy = orderProxy;
    }

    public bool Execute(IMessage message)
    {
        return orderProxy.Create((Inventory)message);
    }

    public bool Rollback(IMessage message)
    {
        return orderProxy.Delete((Inventory)message);
    }
}