using source.structs;

namespace source._1000._1038;

public class Solution
{
    public TreeNode? BstToGst(TreeNode? root)
    {
        var sum = 0;
        RightRootLeft(root, ref sum);
        return root;
    }

    private static void RightRootLeft(TreeNode? root, ref int sum)
    {
        while (true)
        {
            if (root == null) return;

            RightRootLeft(root.right, ref sum);
            sum += root.val;
            root.val = sum;
            root = root.left;
        }
    }
}