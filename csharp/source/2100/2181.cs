using source.Structs;

namespace source._2100;

/// <summary>
///     <a href="https://leetcode.cn/problems/merge-nodes-in-between-zeros">
///         Merge Nodes in Between Zeros
///     </a>
/// </summary>
public class Solution
{
    public ListNode? MergeNodes(ListNode head)
    {
        SplitNode(head).Select(ToOneNode).Aggregate(head, (acc, val) => acc.next = val);
        ListNode? res = head.next;
        head.next = null;
        return res;
    }

    private static IList<ListNode> SplitNode(ListNode? head)
    {
        if (head is null) return [];

        var nodes = new List<ListNode>();
        ListNode? cur = head = head.next;
        while (cur?.next is not null)
        {
            while (cur?.next?.val is not 0)
            {
                cur = cur?.next;
            }

            nodes.Add(head);
            ListNode? next = cur.next.next;
            cur.next = null;
            cur = head = next;
        }

        return nodes;
    }

    private static ListNode ToOneNode(ListNode node)
    {
        int val = 0;
        ListNode? cur = node;
        while (cur is not null)
        {
            val += cur.val;
            cur = cur.next;
        }

        node.next = null;
        node.val = val;
        return node;
    }
}