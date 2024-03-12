using source.Structs;

namespace source._1200._1261;

public class FindElements
{

    private HashSet<int> _vals = new();

    public FindElements(TreeNode root)
    {
        if (root is null) return;
        Recover(root, 0);
    }

    public bool Find(int target)
    {
        return _vals.Contains(target);
    }

    private void Recover(TreeNode node, int val)
    {
        node.val = val;
        _vals.Add(val);

        if (node.left is not null)
            Recover(node.left, 2 * val + 1);
        if (node.right is not null)
            Recover(node.right, 2 * val + 2);
    }
}