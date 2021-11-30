namespace CommandPattern.Demo;

public class Orchestrator : IOrchestrator
{
    private readonly ICommand orderCommand;
    private readonly ICommand inventoryCommand;

    public Orchestrator(ICommand orderCommand, ICommand inventoryCommand)
    {
        this.orderCommand = orderCommand;
        this.inventoryCommand = inventoryCommand;
    }

    public bool CreateOrder(Order order)
    {
        if (orderCommand.Execute(order))
        {
            if (inventoryCommand.Execute(new Inventory(order.ProductName, order.Quantity)))
            {
                return true;
            }
            else
            {
                return orderCommand.Rollback(order);
            }
        }
        return false;
    }
}
