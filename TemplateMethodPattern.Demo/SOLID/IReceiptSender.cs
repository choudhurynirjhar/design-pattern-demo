namespace TemplateMethodPattern.Demo.SOLID
{
    public interface IReceiptSender
    {
        void SendReceipt();
    }

    public class EmailReceiptSender : IReceiptSender
    {
        public void SendReceipt()
        {
            Console.WriteLine("Email Sent");
        }
    }

    public class TextReceiptSender : IReceiptSender
    {
        public void SendReceipt()
        {
            Console.WriteLine("Text Sent");
        }
    }
}