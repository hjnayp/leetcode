using source.Structs;

namespace source._2600._2641;

public class Solution
{
    public TreeNode ReplaceValueInTree(TreeNode root)
    {
        var nodes = new List<TreeNode> { root };
        root.val = 0;
        while (nodes.Count > 0)
        {
            int sum = nodes.Sum(node => (node.left?.val ?? 0) + (node.right?.val ?? 0));
            int n = nodes.Count;
            for (var i = 0; i < n; ++i)
            {
                TreeNode node = nodes[i];
                int sonSum = (node.left?.val ?? 0) + (node.right?.val ?? 0);
                if (node.left is not null)
                {
                    node.left.val = sum - sonSum;
                    nodes.Add(node.left);
                }

                if (node.right is not null)
                {
                    node.right.val = sum - sonSum;
                    nodes.Add(node.right);
                }
            }

            nodes.RemoveRange(0, n);
        }

        return root;
    }
}