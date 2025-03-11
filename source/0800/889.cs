using source.Structs;

namespace source._0800._889;

/// <summary>
///     https://leetcode.cn/problems/construct-binary-tree-from-preorder-and-postorder-traversal/description/
/// </summary>
public class Solution
{
    public TreeNode? ConstructFromPrePost(int[] preorder, int[] postorder)
    {
        int n = preorder.Length;
        var posMap = new Dictionary<int, int>();
        for (int i = 0; i < n; ++i)
        {
            posMap[postorder[i]] = i;
        }

        return CreateTree(0, n - 1, 0, n - 1);

        TreeNode? CreateTree(int preLeft, int preRight, int postLeft, int postRight)
        {
            if (preLeft > preRight) return null;

            int leftCnt = 0;
            if (preLeft < preRight)
            {
                leftCnt = posMap[preorder[preLeft + 1]] - postLeft + 1;
            }

            return new TreeNode(
                preorder[preLeft],
                CreateTree(preLeft + 1, preLeft + leftCnt, postLeft, postLeft + leftCnt),
                CreateTree(preLeft + leftCnt + 1, preRight, postLeft + leftCnt, postRight - 1)
            );
        }
    }
}