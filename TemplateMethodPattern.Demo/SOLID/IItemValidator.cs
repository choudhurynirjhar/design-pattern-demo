namespace TemplateMethodPattern.Demo.SOLID
{
    public interface IItemValidator
    {
        void ValidateItem();
    }

    public class ItemValidator : IItemValidator
    {
        public void ValidateItem()
        {
            Console.WriteLine("Item validated");
        }
    }
}