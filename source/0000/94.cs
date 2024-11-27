using source.Structs;

namespace source._0000._94;

/// <summary>
///     <a href="https://leetcode.cn/problems/binary-tree-inorder-traversal/description/">
///         Binary Tree Inorder Traversal
///     </a>
/// </summary>
public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> path = [];
        Traversal(root);

        return path;

        void Traversal(TreeNode? node)
        {
            if (node is null) return;

            Traversal(node.left);
            path.Add(node.val);
            Traversal(node.right);
        }
    }
}