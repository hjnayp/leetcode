using source.Structs;

namespace source._0800;

public class Solution
{
    public TreeNode? ConstructFromPrePost(int[] preorder, int[] postorder)
    {
        var pos = new Dictionary<int, int>();
        for (var i = 0; i < preorder.Length; i++)
            pos[preorder[i]] = i;

        return CreateTree(0, preorder.Length - 1, 0, postorder.Length - 1);

        TreeNode? CreateTree(int preLeft, int preRight, int postLeft, int postRight)
        {
            if (postLeft > postRight)
                return null;

            var root = new TreeNode(preorder[preLeft]);
            if (preLeft == preRight)
                return root;

            int leftNum = pos[preorder[preLeft + 1]] - postLeft + 1;
            root.left = CreateTree(preLeft + 1, preLeft + leftNum, postLeft, postLeft + leftNum - 1);
            root.right = CreateTree(preLeft + leftNum + 1, preRight, postLeft + leftNum, postRight - 1);
            return root;
        }
    }
}