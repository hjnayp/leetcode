namespace source._1600._1600;

public class FamilyTree<T>
{
    public FamilyTree(T val)
    {
        Val = val;
        IsDead = false;
    }

    public T Val { get; set; }
    public bool IsDead { get; set; }
    public IList<FamilyTree<T>> Children { get; } = new List<FamilyTree<T>>();

    public void AddChild(FamilyTree<T> child)
    {
        Children.Add(child);
    }
}

public class ThroneInheritance
{
    private readonly FamilyTree<string> _root;
    private readonly Dictionary<string, FamilyTree<string>> _nameToNode = new();

    public ThroneInheritance(string kingName)
    {
        _root = new FamilyTree<string>(kingName);
        _nameToNode[kingName] = _root;
    }

    public void Birth(string parentName, string childName)
    {
        FamilyTree<string> parent = _nameToNode[parentName];
        var child = new FamilyTree<string>(childName);
        parent.AddChild(child);
        _nameToNode[childName] = child;
    }

    public void Death(string name)
    {
        _nameToNode[name].IsDead = true;
    }

    public IList<string> GetInheritanceOrder()
    {
        var res = new List<string>();
        Successor(_root);
        return res;

        void Successor(FamilyTree<string> node)
        {
            if (!node.IsDead)
                res.Add(node.Val);
            foreach (FamilyTree<string> child in node.Children)
                Successor(child);
        }
    }
}