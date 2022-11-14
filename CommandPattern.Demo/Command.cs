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
    private readonly IProxy<Inventory> inventoryProxy;

    public InventoryCommand(IProxy<Inventory> inventoryProxy)
    {
        this.inventoryProxy = inventoryProxy;
    }

    public bool Execute(IMessage message)
    {
        return inventoryProxy.Create((Inventory)message);
    }

    public bool Rollback(IMessage message)
    {
        return inventoryProxy.Delete((Inventory)message);
    }
}