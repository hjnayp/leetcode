using source.Structs;

namespace source._0000._94;

public class Solution
{
    private List<int> _path = new();

    public IList<int> InorderTraversal(TreeNode root)
    {
        Traversal(root);
        return _path;
    }

    public void Traversal(TreeNode? node)
    {
        if (node is null)
            return;

        Traversal(node.left);
        _path.Add(node.val);
        Traversal(node.right);
    }
}