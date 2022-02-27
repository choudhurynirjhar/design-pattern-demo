namespace CompositePattern.Demo;
internal class CompositeNode : Node
{
    private List<Node> children = new();
    private readonly string name;
    private readonly Node? parentNode;

    public override string Name => name;

    public CompositeNode(string name, Node? parentNode = null)
    {
        this.name = name;
        this.parentNode = parentNode;
    }

    public override void Add(Node node)
    {
        children.Add(node);
    }

    public override void Remove(Node node)
    {
        children.Remove(node);
    }

    public override void PrintParent()
    {
        if (parentNode != null)
            Console.WriteLine($"Parent: {parentNode.Name}");
        else
            Console.WriteLine("Root node");
    }

    public override void PrintChildren()
    {
        Console.WriteLine
            ($"Children: {string.Join(',', children.Select(c => c.Name))}");
    }
}
