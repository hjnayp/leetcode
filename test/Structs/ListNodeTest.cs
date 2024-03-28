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
    }

    [TestMethod]
    public void TestOperatorEqual()
    {
        ListNode? list1 = ListNode.FromArray(1, 2, 3);
        ListNode? list2 = ListNode.FromArray(1, 2, 3);
        if (list1 != list2)
            Assert.Fail();

        list1 = ListNode.FromArray(1, 2, 3);
        list2 = ListNode.FromArray(1, 2, 4);
        if (list1 == list2)
            Assert.Fail();
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