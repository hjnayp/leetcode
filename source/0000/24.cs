using source.Structs;

namespace source._0000._24;

/// <summary>
///     <a href="https://leetcode.cn/problems/swap-nodes-in-pairs">
///         Swap Nodes in Pairs
///     </a>
/// </summary>
public class Solution
{
    public ListNode? SwapPairs(ListNode? head)
    {
        if (head is null)
        {
            return null;
        }

        var dummy = new ListNode(0);
        dummy.next = head;
        ListNode? current = dummy;
        while (head?.next is not null)
        {
            ListNode? temp = head;
            head = head.next;
            current.next = head;
            temp.next = head.next;
            head.next = temp;
            head = temp.next;
            current = current.next?.next;
        }

        ListNode? res = dummy.next;
        dummy.next = null;
        return res;
    }
}