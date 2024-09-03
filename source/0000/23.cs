using source.Structs;

namespace source._0000._23;

/// <summary>
///     <a href="https://leetcode.cn/problems/merge-k-sorted-lists">Merge k Sorted Lists</a>
/// </summary>
public class Solution
{
    public ListNode? MergeKLists(ListNode?[] lists)
    {
        Queue<ListNode?> listNodes = new();
        foreach (ListNode? listNode in lists)
        {
            listNodes.Enqueue(listNode);
        }

        while (listNodes.Count > 1)
        {
            ListNode? list1 = listNodes.Dequeue();
            ListNode? list2 = listNodes.Dequeue();
            listNodes.Enqueue(MergeTwoLists(list1, list2));
        }

        return listNodes.Count > 0 ? listNodes.Dequeue() : null;
    }

    private static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
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