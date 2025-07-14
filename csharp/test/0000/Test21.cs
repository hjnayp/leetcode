using JetBrains.Annotations;
using source._0000._21;
using source.Structs;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test21
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        ListNode? list1 = ListNode.FromArray(1, 2, 4);
        ListNode? list2 = ListNode.FromArray(1, 3, 4);
        ListNode? result = solution.MergeTwoLists(list1, list2);
        ListNode? expected = ListNode.FromArray(1, 1, 2, 3, 4, 4);
        Assert.IsTrue(ListNode.AreEquivalent(expected, result));

        list1 = ListNode.FromArray(1, 2, 4, 5, 6);
        list2 = ListNode.FromArray(1, 3, 4, 5);
        result = solution.MergeTwoLists(list1, list2);
        expected = ListNode.FromArray(1, 1, 2, 3, 4, 4, 5, 5, 6);
        Assert.IsTrue(ListNode.AreEquivalent(expected, result));
    }

    [TestMethod]
    public void TestSolution_WhenOneListIsNull_ShouldReturnAnother()
    {
        var solution = new Solution();
        ListNode? list = ListNode.FromArray(1, 3, 4);
        ListNode? result = solution.MergeTwoLists(null, list);
        Assert.IsTrue(ListNode.AreEquivalent(list, result));

        result = solution.MergeTwoLists(list, null);
        Assert.IsTrue(ListNode.AreEquivalent(list, result));
    }

    [TestMethod]
    public void TestSolution_WhenTwoListBothNull_ShouldReturnNull()
    {
        var solution = new Solution();
        ListNode? result = solution.MergeTwoLists(null, null);
        Assert.IsTrue(ListNode.AreEquivalent(null, result));
    }
}