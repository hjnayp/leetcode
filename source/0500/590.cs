using source.Structs;

namespace source._0500._590;

public class Solution
{
    public IList<int> Postorder(Node root)
    {
        var path = new List<int>();
        Dfs(root);
        return path;

        void Dfs(Node? node)
        {
            if (node is null)
            {
                return;
            }

            foreach (Node child in node.children)
            {
                Dfs(child);
            }

            path.Add(node.val);
        }
    }
}