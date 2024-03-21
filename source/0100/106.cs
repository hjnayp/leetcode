using source.Structs;

namespace source._0100._106;

public class Solution
{
    public TreeNode? BuildTree(int[] inorder, int[] postorder)
    {
        var pos = new Dictionary<int, int>();
        for (var i = 0; i < inorder.Length; i++)
            pos[inorder[i]] = i;
        return CreateTree(0, inorder.Length - 1, 0, postorder.Length - 1);

        TreeNode? CreateTree(int inLeft, int inRight, int postLeft, int postRight)
        {
            if (postLeft > postRight) return null;

            var root = new TreeNode(postorder[postRight]);
            int inRoot = pos[root.val];
            int rightNum = inRight - inRoot;
            root.left = CreateTree(inLeft, inRoot - 1, postLeft, postRight - rightNum - 1);
            root.right = CreateTree(inRoot + 1, inRight, postRight - rightNum, postRight - 1);
            return root;
        }
    }
}