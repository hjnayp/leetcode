using System.Diagnostics.CodeAnalysis;
using source.Structs;

namespace source._1600._1609;

/// <summary>
///     <a href="https://leetcode.cn/problems/even-odd-tree/">
///         1609. Even Odd Tree
///     </a>
/// </summary>
public class Solution
{
    public bool IsEvenOddTree(TreeNode root)
    {
        int level = 0;
        List<TreeNode> nodes = [root];
        while (TryCheckIsLevelValid(nodes, level, out IList<TreeNode>? nextLevel))
        {
            ++level;
            if (nextLevel.Count == 0) return true;

            nodes = nextLevel.ToList();
        }

        return false;
    }

    private static bool TryCheckIsLevelValid(IList<TreeNode> nodes,
                                             int level,
                                             [NotNullWhen(true)] out IList<TreeNode>? nextLevel)
    {
        int sign = (level & 1) ^ 1;
        int trending = (level & 1) is 1 ? -1 : 1;

        TreeNode? preNode = null;
        nextLevel = new List<TreeNode>();
        foreach (TreeNode node in nodes)
        {
            if ((node.val & 1) != sign)
            {
                return false;
            }

            if (preNode is not null
                && node.val.CompareTo(preNode.val) != trending)
            {
                return false;
            }

            preNode = node;

            if (node.left is not null)
            {
                nextLevel.Add(node.left);
            }

            if (node.right is not null)
            {
                nextLevel.Add(node.right);
            }
        }

        return true;
    }
}