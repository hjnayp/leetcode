using source.Structs;

namespace source._0800._894;

/// <summary>
///     https://leetcode.cn/problems/all-possible-full-binary-trees/description
/// </summary>
public class Solution
{
    public IList<TreeNode> AllPossibleFBT(int n)
    {
        if (n % 2 == 0) return Array.Empty<TreeNode>();

        var res = new List<TreeNode>();
        if (n == 1)
        {
            res.Add(new TreeNode());
            return res;
        }

        for (int i = 1; i < n; i += 2)
        {
            IList<TreeNode>? left = AllPossibleFBT(i);
            IList<TreeNode>? right = AllPossibleFBT(n - i - 1);

            foreach (TreeNode? l in left)
            foreach (TreeNode? r in right)
            {
                var root = new TreeNode(0, l, r);
                res.Add(root);
            }
        }

        return res;
    }
}