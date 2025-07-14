using source.Structs;

namespace source._0000._25;

/// <summary>
///     <a href="https://leetcode.cn/problems/reverse-nodes-in-k-group">
///         Reverse Nodes in k-Group
///     </a>
/// </summary>
public class Solution
{
    public ListNode? ReverseKGroup(ListNode? head, int k)
    {
        if (k == 1 || head is null)
        {
            return head;
        }

        ListNode? end = head;
        int i = k;
        while (i > 1)
        {
            --i;
            end = end.next;
            if (end is null)
            {
                return head;
            }
        }

        ListNode? next = end.next;
        end.next = null;
        ReverseNode(head);
        head.next = ReverseKGroup(next, k);
        return end;
    }

    private void ReverseNode(ListNode? node)
    {
        ListNode? pre = null;
        while (node is not null)
        {
            ListNode? next = node.next;
            node.next = pre;
            pre = node;
            node = next;
        }
    }
}