namespace FactoryMethodPattern.Demo
{
    public interface ILawnmowerCatalogFactory
    {
        ILawnmowerCatalog CreateCatalog(string type);
    }
}