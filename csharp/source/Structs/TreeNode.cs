namespace source.Structs;

public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public static TreeNode? CreateTreeWithList(IList<int?> list)
    {
        if (list.Count == 0 || list[0] is null) return null;
        
        var nodes = new List<TreeNode?>(list.Count);
        nodes.AddRange(list.Select(val => val.HasValue ? new TreeNode(val.Value) : null));

        var queue = new Queue<TreeNode>();
        queue.Enqueue(nodes[0]!);
        var i = 1;
        int n = list.Count;
        while (queue.Any())
        {
            TreeNode node = queue.Dequeue();
            node.left = i >= n ? null : nodes[i++];
            node.right = i >= n ? null : nodes[i++];
            if (node.left != null) queue.Enqueue(node.left);
            if (node.right != null) queue.Enqueue(node.right);
        }

        return nodes[0];
    }

    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;

    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != GetType()) return false;

        var node = (TreeNode)obj;
        return val == node.val && Equals(left, node.left) && Equals(right, node.right);
    }

    public override int GetHashCode()
    {
        return val.GetHashCode() ^ (left?.GetHashCode() ?? 0) ^ (right?.GetHashCode() ?? 0);
    }
}