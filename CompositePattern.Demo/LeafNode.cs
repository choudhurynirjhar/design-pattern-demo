namespace CompositePattern.Demo;
internal class LeafNode : Node
{
    private readonly string name;
    private readonly Node parentNode;

    public override string Name => name;

    public LeafNode(string name, Node parentNode)
    {
        this.name = name;
        this.parentNode = parentNode;
    }

    public override void PrintParent()
    {
        Console.WriteLine($"Parent: {parentNode.Name}");
    }
}