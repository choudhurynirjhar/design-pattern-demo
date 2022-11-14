namespace FacadePattern.Demo;

public interface IInventoryService
{
    Task<string[]> GetAsync();
}

internal class InventoryService : IInventoryService
{
    public Task<string[]> GetAsync()
    {
        return Task.FromResult(new string[] { "Book", "Pen" });
    }
}

public interface IPaymentService
{
    Task PayAsync(double amount, string item);
}

internal class PaymentService : IPaymentService
{
    public Task PayAsync(double amount, string item)
    {
        Console.WriteLine($"Paying amount: {amount} for item: {item}");
        return Task.CompletedTask;
    }
}

public interface INotificationService
{
    Task SendAsync(string message);
}

internal class NotificationService : INotificationService
{
    public Task SendAsync(string message)
    {
        Console.WriteLine($"Sending notification message: {message}");
        return Task.CompletedTask;
    }
}