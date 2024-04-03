using source.Structs;

namespace source._1300._1379;

public class Solution
{
    public TreeNode? GetTargetCopy(TreeNode? original, TreeNode? cloned, TreeNode? target)
    {
        if (original is null) return null;
        if (original == target) return cloned;

        TreeNode? left = GetTargetCopy(original.left, cloned.left, target);
        return left ?? GetTargetCopy(original.right, cloned.right, target);
    }
}