using System.Diagnostics.CodeAnalysis;

namespace source.Structs;

public class ListNode(int val = 0, ListNode? next = null)
{
    public ListNode? next = next;
    public int val = val;

    public static ListNode FromArray(params int[] nums)
    {
        if (nums.Length == 0)
        {
            throw new ArgumentException("nums is empty");
        }

        var listNode = new ListNode(nums[0]);
        ListNode head = listNode;
        for (int i = 1; i < nums.Length; i++)
        {
            var node = new ListNode(nums[i]);
            listNode.next = node;
            listNode = listNode.next;
        }

        listNode.next = null;
        return head;
    }

    public static bool TryCreateList(int[] nums, [NotNullWhen(true)] out ListNode? head)
    {
        head = null;

        if (nums.Length == 0) return false;

        head = FromArray(nums);
        return true;
    }

    public static bool AreEquivalent(ListNode? a, ListNode? b)
    {
        if (ReferenceEquals(a, b))
        {
            return true;
        }

        if (a is null || b is null)
        {
            return false;
        }

        return a.val == b.val && AreEquivalent(a.next, b.next);
    }
}