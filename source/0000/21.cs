using source.Structs;

namespace source._0000._21;

/// <summary>
///     <a href="https://leetcode.cn/problems/merge-two-sorted-lists">Merge Two Sorted Lists</a>
/// </summary>
public class Solution
{
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        if (list1 is null)
        {
            return list2;
        }

        if (list2 is null)
        {
            return list1;
        }

        var head = new ListNode();
        ListNode? current = head;

        while (list1 is not null && list2 is not null)
        {
            ListNode addNode = list1;
            if (list1.val > list2.val)
            {
                addNode = list2;
                list2 = list2.next;
            }
            else
            {
                list1 = list1.next;
            }

            addNode.next = null;
            current.next = addNode;
            current = current.next;
        }

        if (list1 is not null)
        {
            current.next = list1;
        }

        if (list2 is not null)
        {
            current.next = list2;
        }

        ListNode? res = head.next;
        head.next = null;
        return res;
    }
}