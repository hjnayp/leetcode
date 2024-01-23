using source.structs;

namespace source._2400._2415;

public class Solution
{
    private static void Dfs(TreeNode? left, TreeNode? right, bool reverse)
    {
        if (left == null || right == null)
            return;

        if (reverse)
            (left.val, right.val) = (right.val, left.val);

        Dfs(left.left, right.right, !reverse);
        Dfs(left.right, right.left, !reverse);
    }

    public TreeNode ReverseOddLevels(TreeNode root)
    {
        Dfs(root.left, root.right, true);
        return root;
    }
}