namespace FactoryMethodPattern.Demo
{
    public class LawnmowerCatalogFactory : ILawnmowerCatalogFactory
    {
        public ILawnmowerCatalog CreateCatalog(string type)
        {
            return type switch
            {
                "Diesel" => new DieselLawnmowerCatalog(),
                "Electric" => new ElectricLawnmowerCatalog(),
                _ => new ManualLawnmowerCatalog(),
            };
        }
    }

    public class XyzLawnmowerCatalogFactory : ILawnmowerCatalogFactory
    {
        public ILawnmowerCatalog CreateCatalog(string type)
        {
            return type switch
            {
                "Diesel" => new XyzDieselLawnmowerCatalog(),
                "Electric" => new XyzElectricLawnmowerCatalog(),
                _ => new XyzManualLawnmowerCatalog(),
            };
        }
    }
}
