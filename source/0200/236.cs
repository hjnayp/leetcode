using source.Structs;

namespace source._0200._236;

public class Solution
{
    private Dictionary<int, TreeNode> _parents = new();

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        _parents.Clear();
        Dfs(root, root, p, q);
        var visited = new Dictionary<int, bool>();
        while (p != _parents[p.val])
        {
            visited[p.val] = true;
            p = _parents[p.val];
        }

        while (q != _parents[q.val])
        {
            if (visited.ContainsKey(q.val))
                return q;
            q = _parents[q.val];
        }

        return q;
    }

    public void Dfs(TreeNode node, TreeNode parent, TreeNode p, TreeNode q)
    {
        _parents[node.val] = parent;
        if (_parents.ContainsKey(p.val) && _parents.ContainsKey(q.val))
            return;

        if (node.left is not null)
            Dfs(node.left, node, p, q);
        if (node.right is not null)
            Dfs(node.right, node, p, q);
    }
}