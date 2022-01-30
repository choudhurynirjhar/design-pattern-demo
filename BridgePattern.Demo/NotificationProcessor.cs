namespace BridgePattern.Demo;
public interface INotificationProcessor
{
    void ProcessNotification(string message);
}

public class TextNotificationProcessor : INotificationProcessor
{
    private readonly INotificationSender notificationSender;

    public TextNotificationProcessor(INotificationSender notificationSender)
    {
        this.notificationSender = notificationSender;
    }
    public void ProcessNotification(string message)
    {
        notificationSender.SendNotification(message);
    }
}

public interface INotificationSender
{
    void SendNotification(string message);
}

public class TextNotificationSender : INotificationSender 
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Text: {message}");
    }
}

public class EmailNotificationProcessor : INotificationProcessor
{
    private readonly INotificationSender notificationSender;

    public EmailNotificationProcessor(INotificationSender notificationSender)
    {
        this.notificationSender = notificationSender;
    }
    public void ProcessNotification(string message)
    {
        notificationSender.SendNotification($"<html>{message}</html>");
    }
}

public class EmailNotificationSender : INotificationSender
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}