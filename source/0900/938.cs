using source.Structs;

namespace source._0900._938;

public class Solution
{
    public int RangeSumBST(TreeNode? root, int low, int high)
    {
        if (root is null)
            return 0;

        int val = root.val;

        if (val < low)
            return RangeSumBST(root.right, low, high);

        if (val > high)
            return RangeSumBST(root.left, low, high);

        return val + RangeSumBST(root.left, low, val) + RangeSumBST(root.right, val, high);
    }
}