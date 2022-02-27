namespace DecoratorPattern.Demo;
public class VanillaCake : ICake
{
    private readonly List<string> layers = new();
    public void AddLayer(string layer)
    {
        layers.Add(layer);
    }

    public void PrintLayers()
    {
        foreach (var layer in layers)
        {
            Console.WriteLine($"Layer: {layer}");
            Console.WriteLine(" ---------- ");
        }
    }
}