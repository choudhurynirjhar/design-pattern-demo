namespace FactoryMethodPattern.Demo
{
    public interface ILawnmowerCatalog
    {
        Lawnmower[] GetLawnmowers();
    }

    public class DieselLawnmowerCatalog : ILawnmowerCatalog
    {
        public Lawnmower[] GetLawnmowers()
        {
            return new[] { new Lawnmower { Name = "I am Diesel Lawnmower" } };
        }
    }

    public class XyzDieselLawnmowerCatalog : ILawnmowerCatalog
    {
        public Lawnmower[] GetLawnmowers()
        {
            return new[] { new Lawnmower { Name = "XYZ: I am Diesel Lawnmower" } };
        }
    }

    public class ElectricLawnmowerCatalog : ILawnmowerCatalog
    {
        public Lawnmower[] GetLawnmowers()
        {
            return new[] { new Lawnmower { Name = "I am Electric Lawnmower" } };
        }
    }

    public class XyzElectricLawnmowerCatalog : ILawnmowerCatalog
    {
        public Lawnmower[] GetLawnmowers()
        {
            return new[] { new Lawnmower { Name = "XYZ: I am Electric Lawnmower" } };
        }
    }

    public class ManualLawnmowerCatalog : ILawnmowerCatalog
    {
        public Lawnmower[] GetLawnmowers()
        {
            return new[] { new Lawnmower { Name = "I am Manual Lawnmower" } };
        }
    }

    public class XyzManualLawnmowerCatalog : ILawnmowerCatalog
    {
        public Lawnmower[] GetLawnmowers()
        {
            return new[] { new Lawnmower { Name = "XYZ: I am Manual Lawnmower" } };
        }
    }
}