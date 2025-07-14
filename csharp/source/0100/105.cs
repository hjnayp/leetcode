using source.Structs;

namespace source._0100._105;

public class Solution
{
    public TreeNode? BuildTree(int[] preorder, int[] inorder)
    {
        var pos = new Dictionary<int, int>();
        for (var i = 0; i < inorder.Length; i++)
            pos[inorder[i]] = i;

        return CreateTree(0, preorder.Length - 1, 0, inorder.Length - 1);

        TreeNode? CreateTree(int preLeft, int preRight, int inLeft, int inRight)
        {
            if (preLeft > preRight)
                return null;

            var root = new TreeNode(preorder[preLeft]);
            int inRoot = pos[root.val];
            int leftNum = inRoot - inLeft;
            root.left = CreateTree(preLeft + 1, preLeft + leftNum, inLeft, inRoot - 1);
            root.right = CreateTree(preLeft + leftNum + 1, preRight, inRoot + 1, inRight);
            return root;
        }
    }
}