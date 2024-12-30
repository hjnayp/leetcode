using source.Structs;

namespace source._1300;

/// <summary>
///     <a href="https://leetcode.cn/problems/linked-list-in-binary-tree/description">
///         1367.Linked List in Binary Tree
///     </a>
/// </summary>
public class Solution
{
    public bool IsSubPath(ListNode head, TreeNode? root)
    {
        if (root is null) return false;

        return Dfs(root, head) || IsSubPath(head, root.left) || IsSubPath(head, root.right);
    }

    private bool Dfs(TreeNode? node, ListNode? head)
    {
        if (head is null) return true;

        if (node is null) return false;

        if (node.val != head.val) return false;

        return Dfs(node.left, head.next) || Dfs(node.right, head.next);
    }
}