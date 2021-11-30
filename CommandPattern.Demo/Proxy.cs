namespace CommandPattern.Demo;
public interface IProxy<T>
{
    bool Create(T item);
    bool Delete(T item);
}

public class InventoryProxy : IProxy<Inventory>
{
    public bool Create(Inventory inventory)
    {
        Console.WriteLine($"Created inventory for product: {inventory.ProductName}");
        return false;
    }

    public bool Delete(Inventory inventory)
    {
        Console.WriteLine($"Deleted inventory for product: {inventory.ProductName}");
        return true;
    }
}

public record Inventory(string ProductName, int Quentity) : IMessage;

public class OrderProxy : IProxy<Order>
{
    public bool Create(Order order)
    {
        Console.WriteLine($"Created order for product: {order.ProductName}");
        return true;
    }

    public bool Delete(Order order)
    {
        Console.WriteLine($"Deleted order for product: {order.ProductName}");
        return true;
    }
}

public record Order(string ProductName, int Quantity) : IMessage;
