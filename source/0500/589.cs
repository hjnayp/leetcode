using source.Structs;

namespace test._0500._589;

public class Solution
{
    public IList<int> Preorder(Node root)
    {
        var res = new List<int>();
        Dfs(root);
        return res;

        void Dfs(Node? node)
        {
            if (node is null)
                return;

            res.Add(node.val);
            foreach (Node child in node.children)
                Dfs(child);
        }
    }
}