namespace TemplateMethodPattern.Demo.TemplateMethod;

internal class EmailCart : Cart
{
    protected override void SendReceipt()
    {
        Console.WriteLine("Email Sent");
    }
}

internal class TextCart : Cart
{
    protected override void SendReceipt()
    {
        Console.WriteLine("Text Sent");
    }
}