using JetBrains.Annotations;
using source.Structs;

namespace test.Structs;

[TestClass]
[TestSubject(typeof(ListNode))]
public class ListNodeTest
{
    [TestMethod]
    public void TestConvertFromArray()
    {
        ConvertArrayToListNode(new[] { 1, 2, 3 });
        ConvertArrayToListNode(new[] { 0, 3, 5 });
        ConvertArrayToListNode(Array.Empty<int>());
    }

    [TestMethod]
    public void TestOperatorEqual()
    {
        ListNode? list1 = ListNode.FromArray(1, 2, 3);
        ListNode? list2 = ListNode.FromArray(1, 2, 3);
        Assert.IsTrue(list1 == list2);

        list1 = ListNode.FromArray(1, 2, 3);
        list2 = ListNode.FromArray(1, 2, 4);
        Assert.IsTrue(list1 != list2);
    }

    [TestMethod]
    public void TestFields()
    {
        var listNode = new ListNode(1);
        Assert.AreEqual(1, listNode.val);
        Assert.IsNull(listNode.next);

        var listNode2 = new ListNode(2, listNode);
        Assert.AreEqual(2, listNode2.val);
        Assert.AreEqual(listNode, listNode2.next);
    }


    private void ConvertArrayToListNode(int[] nums)
    {
        ListNode? listNode = ListNode.FromArray(nums);

        foreach (int t in nums)
        {
            Assert.AreEqual(t, listNode?.val);
            listNode = listNode?.next;
        }
    }
}