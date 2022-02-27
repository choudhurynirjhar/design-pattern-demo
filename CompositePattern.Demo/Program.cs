using CompositePattern.Demo;

var root = new CompositeNode("Root");

var node1 = new CompositeNode("node1", root);
var leaf11 = new LeafNode("leaf11", node1);
var leaf12 = new LeafNode("leaf12", node1);
node1.Add(leaf11);
node1.Add(leaf12);

var node2 = new CompositeNode("node2", root);
var leaf1 = new LeafNode("leaf1", root);

root.Add(leaf1);
root.Add(node1);
root.Add(node2);

Console.WriteLine("Root ======");
root.PrintParent();
root.PrintChildren();

Console.WriteLine("leaf1 ======");
leaf1.PrintParent();

Console.WriteLine("node1 ======");
node1.PrintParent();
node1.PrintChildren();

Console.WriteLine("leaf11 ======");
leaf11.PrintParent();
leaf11.PrintChildren();