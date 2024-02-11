using source.Structs;

namespace source._0100._144;

public class Solution
{
    private List<int> _path = new();

    public IList<int> PreorderTraversal(TreeNode root)
    {
        Dfs(root);
        return _path;
    }

    private void Dfs(TreeNode? node)
    {
        if (node is null)
            return;

        _path.Add(node.val);
        Dfs(node.left);
        Dfs(node.right);
    }
}