using JetBrains.Annotations;
using source._0000._02;
using source.Structs;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test02
{
    [TestMethod]
    public void Normal()
    {
        var solution = new Solution();
        ListNode? list1 = ListNode.FromArray(2, 4, 3);
        ListNode? list2 = ListNode.FromArray(5, 6, 4);
        ListNode? expected = ListNode.FromArray(7, 0, 8);
        ListNode? actual = solution.AddTwoNumbers(list1, list2);
        Assert.IsTrue(ListNode.CompareListNodeEquivalent(expected, actual));

        list1 = ListNode.FromArray(0);
        list2 = ListNode.FromArray(0);
        expected = ListNode.FromArray(0);
        actual = solution.AddTwoNumbers(list1, list2);
        Assert.IsTrue(ListNode.CompareListNodeEquivalent(expected, actual));

        list1 = ListNode.FromArray(9, 9, 9, 9, 9, 9, 9);
        list2 = ListNode.FromArray(9, 9, 9, 9);
        expected = ListNode.FromArray(8, 9, 9, 9, 0, 0, 0, 1);
        actual = solution.AddTwoNumbers(list1, list2);
        Assert.IsTrue(ListNode.CompareListNodeEquivalent(expected, actual));
    }
}