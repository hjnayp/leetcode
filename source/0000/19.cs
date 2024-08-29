using source.Structs;

namespace source._0000._19;

public class Solution
{
    public ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode? end = head;
        ListNode? pre = head;

        while (n > 0)
        {
            end = end?.next;
            --n;
        }

        while (end?.next is not null)
        {
            end = end.next;
            pre = pre?.next;
        }

        if (end is null)
        {
            return pre.next;
        }

        pre.next = pre.next?.next;
        return head;
    }
}