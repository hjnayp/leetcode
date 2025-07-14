using source.Structs;

namespace source._0900._987;

public class Solution
{
    private List<Tuple<int, int, int>> _nodes = new();

    public IList<IList<int>> VerticalTraversal(TreeNode root)
    {
        Dfs(root, 0, 0);
        _nodes.Sort((a, b) =>
        {
            if (a.Item1 != b.Item1)
                return a.Item1.CompareTo(b.Item1);
            if (a.Item2 != b.Item2)
                return a.Item2.CompareTo(b.Item2);
            return a.Item3.CompareTo(b.Item3);
        });

        int nowCol = _nodes[0].Item1 - 1;
        var result = new List<IList<int>>();
        var nodeRow = new List<int>();
        foreach ((int col, int row, int value) in _nodes)
        {
            if (col != nowCol)
            {
                if (nodeRow.Count > 0)
                    result.Add(nodeRow);
                nodeRow = new List<int>();
                nowCol = col;
            }

            nodeRow.Add(value);
        }

        if (nodeRow.Count > 0)
            result.Add(nodeRow);

        return result;
    }

    private void Dfs(TreeNode? node, int row, int col)
    {
        if (node is null)
            return;

        _nodes.Add(new Tuple<int, int, int>(col, row, node.val));
        Dfs(node.left, row + 1, col - 1);
        Dfs(node.right, row + 1, col + 1);
    }
}