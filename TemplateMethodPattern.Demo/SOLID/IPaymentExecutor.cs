namespace TemplateMethodPattern.Demo.SOLID
{
    public interface IPaymentExecutor
    {
        void ExecutePayment();
    }

    public class PaymentExecutor : IPaymentExecutor
    {
        public void ExecutePayment()
        {
            Console.WriteLine("Payment executed");
        }
    }
}