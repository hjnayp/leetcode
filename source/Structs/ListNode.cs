namespace source.Structs;

public class ListNode
{
    public ListNode? next;
    public int val;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public static ListNode? FromArray(params int[] nums)
    {
        if (nums.Length == 0)
        {
            return null;
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

    public static bool CompareListNodeEquivalent(ListNode? a, ListNode? b)
    {
        if (ReferenceEquals(a, b))
        {
            return true;
        }

        if (a is null || b is null)
        {
            return false;
        }

        return a.val == b.val && CompareListNodeEquivalent(a.next, b.next);
    }
}