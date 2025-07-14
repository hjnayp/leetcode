using source.Structs;

namespace source._2500._2583;

public class Solution
{
    public long KthLargestLevelSum(TreeNode root, int k)
    {
        var levelSum = new List<long>();
        CalLevelSum(root, 1);
        if (levelSum.Count < k) return -1;
        levelSum.Sort();
        return levelSum[^k];

        void CalLevelSum(TreeNode node, int level)
        {
            while (levelSum.Count < level) levelSum.Add(0);

            levelSum[level - 1] += node.val;
            if (node.left is not null) CalLevelSum(node.left, level + 1);
            if (node.right is not null) CalLevelSum(node.right, level + 1);
        }
    }
}