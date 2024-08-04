using source.Structs;

namespace source._0500._572;

/// <summary>
///     https://leetcode.cn/problems/subtree-of-another-tree
/// </summary>
public class Solution
{
    private const string LeftNull = ",left";
    private const string RightNull = ",right";

    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        PreOrder(root, out string rootPath);
        PreOrder(subRoot, out string subRootPath);
        return rootPath.Contains(subRootPath);

        void PreOrder(TreeNode node, out string path)
        {
            path = "," + node.val;
            if (node.left is null)
            {
                path += LeftNull;
            }
            else
            {
                PreOrder(node.left, out string leftPath);
                path += leftPath;
            }

            if (node.right is null)
            {
                path += RightNull;
            }
            else
            {
                PreOrder(node.right, out string rightPath);
                path += rightPath;
            }
        }
    }
}