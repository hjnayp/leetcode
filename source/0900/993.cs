using source.Structs;

namespace source._0900._992;

public class Solution
{
    public bool IsCousins(TreeNode root, int x, int y)
    {
        var nodes = new Queue<TreeNode>();
        nodes.Enqueue(root);

        int xParent = -1;
        int yParent = -1;
        while (nodes.Count > 0)
        {
            var nextNodes = new Queue<TreeNode>();
            while (nodes.Count > 0)
            {
                TreeNode node = nodes.Dequeue();
                if (node.left is not null)
                {
                    nextNodes.Enqueue(node.left);
                    if (node.left.val == x)
                        xParent = node.val;

                    if (node.left.val == y)
                        yParent = node.val;
                }

                if (node.right is not null)
                {
                    nextNodes.Enqueue(node.right);
                    if (node.right.val == x)
                        xParent = node.val;
                    if (node.right.val == y)
                        yParent = node.val;
                }
            }

            if (xParent != -1 && yParent != -1)
                return xParent != yParent;

            if (xParent != yParent)
                return false;

            nodes = nextNodes;
        }

        return false;
    }
}