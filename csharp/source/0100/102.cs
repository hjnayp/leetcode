using source.Structs;

namespace source._0100._102;

public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode? root)
    {
        if (root is null) return new List<IList<int>>();

        var result = new List<IList<int>>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Any())
        {
            int n = queue.Count;
            var level = new List<int>();
            for (int i = 0; i < n; ++i)
            {
                TreeNode node = queue.Dequeue();
                level.Add(node.val);
                if (node.left is not null) queue.Enqueue(node.left);
                if (node.right is not null) queue.Enqueue(node.right);
            }

            result.Add(level);
        }

        return result;
    }
}