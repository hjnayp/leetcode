namespace source.Structs;

public class Node
{
    public IList<Node> children = new List<Node>();
    public int val;

    public Node()
    {
    }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, IList<Node> _children)
    {
        val = _val;
        children = _children;
    }
}