using source.Structs;

namespace source._0000._02;

/// <summary>
///     https://leetcode.cn/problems/add-two-numbers/description/
/// </summary>
public class Solution
{
    public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        var head = new ListNode();
        ListNode? cur = head;
        var carry = 0;

        while (l1 != null || l2 != null || carry > 0)
        {
            int sum = carry;
            sum += l1?.val ?? 0;
            sum += l2?.val ?? 0;

            carry = sum / 10;
            cur.next = new ListNode(sum % 10);
            cur = cur.next;
            l1 = l1?.next ?? null;
            l2 = l2?.next ?? null;
        }

        return head.next;
    }
}