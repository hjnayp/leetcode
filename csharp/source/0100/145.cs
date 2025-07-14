using source.Structs;

namespace source._0100._145;

public class Solution
{
    private readonly List<int> _path = new();

    public IList<int> PostorderTraversal(TreeNode root)
    {
        _path.Clear();
        Dfs(root);
        return _path;
    }

    private void Dfs(TreeNode? node)
    {
        if (node is null)
        {
            return;
        }

        Dfs(node.left);
        Dfs(node.right);
        _path.Add(node.val);
    }
}