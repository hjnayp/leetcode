using source.Structs;

namespace source._0000._94;

/// <summary>
///     https://leetcode.cn/problems/binary-tree-inorder-traversal/description/
/// </summary>
public class Solution
{
    private readonly List<int> _path = [];

    public IList<int> InorderTraversal(TreeNode root)
    {
        _path.Clear();
        Traversal(root);
        return _path;
    }

    public void Traversal(TreeNode? node)
    {
        if (node is null) return;

        Traversal(node.left);
        _path.Add(node.val);
        Traversal(node.right);
    }
}