namespace source.Structs;

public class TreeNode
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

    public static List<int?> TransTreeToList(TreeNode? node)
    {
        var list = new List<int?>();
        var queue = new Queue<TreeNode?>();
        queue.Enqueue(node);
        while (queue.Any())
        {
            TreeNode? nextNode = queue.Dequeue();
            if (nextNode is null)
            {
                list.Add(null);
            }
            else
            {
                list.Add(nextNode.val);
                queue.Enqueue(nextNode.left);
                queue.Enqueue(nextNode.right);
            }
        }

        while (list.Count > 0 && list[^1] == null)
            list.RemoveAt(list.Count - 1);

        return list;
    }

    public TreeNode? left;
    public TreeNode? right;
    public int val;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}