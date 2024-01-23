namespace source.structs;

public class TreeNode
{
    public TreeNode? left;
    public TreeNode? right;
    public int val;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public static TreeNode? CreateTreeWithList(IList<int?> list)
    {
        var nodes = new List<TreeNode?>(list.Count);
        nodes.AddRange(list.Select(val => val.HasValue ? new TreeNode(val.Value) : null));

        var n = nodes.Count;
        for (var i = 0; i < n; ++i)
        {
            var node = nodes[i];
            if (node == null)
                continue;

            var left_index = 2 * i + 1;
            var right_index = 2 * i + 2;
            node.left = left_index < n ? nodes[left_index] : null;
            node.right = right_index < n ? nodes[right_index] : null;
        }

        return nodes[0];
    }

    public static List<int?> TransTreeToList(TreeNode? node)
    {
        var list = new List<int?>();
        var queue = new Queue<TreeNode?>();
        queue.Enqueue(node);
        while (queue.Any())
        {
            var next_node = queue.Dequeue();
            if (next_node == null)
            {
                list.Add(null);
            }
            else
            {
                list.Add(next_node.val);
                queue.Enqueue(next_node.left);
                queue.Enqueue(next_node.right);
            }
        }

        while (list.Count > 0 && list[^1] == null)
            list.RemoveAt(list.Count - 1);

        return list;
    }
}