namespace FactoryMethodPattern.Demo
{
    public interface ILawnmowerCatalogAbstractFactory
    {
        ILawnmowerCatalogFactory CreateFactory(string manufacturer);
    }

    public class LawnmowerCatalogAbstractFactory : ILawnmowerCatalogAbstractFactory
    {
        public ILawnmowerCatalogFactory CreateFactory(string manufacturer)
        {
            return manufacturer switch
            {
                "Xyz" => new XyzLawnmowerCatalogFactory(),
                _ => new LawnmowerCatalogFactory()
            };
        }
    }
}