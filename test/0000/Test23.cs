using JetBrains.Annotations;
using source._0000._23;
using source.Structs;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test23
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();
        ListNode?[] lists =
        [
            ListNode.FromArray(1, 4, 5),
            ListNode.FromArray(1, 3, 4),
            ListNode.FromArray(2, 6)
        ];

        ListNode? expected = ListNode.FromArray(1, 1, 2, 3, 4, 4, 5, 6);
        Assert.IsTrue(ListNode.CompareListNodeEquivalent(expected, solution.MergeKLists(lists)));

        lists = [ListNode.FromArray(1, 4, 5), null, null, ListNode.FromArray(1, 3, 4), ListNode.FromArray(2, 6), null];
        expected = ListNode.FromArray(1, 1, 2, 3, 4, 4, 5, 6);
        Assert.IsTrue(ListNode.CompareListNodeEquivalent(expected, solution.MergeKLists(lists)));

        lists = [ListNode.FromArray(1, 4, 5), ListNode.FromArray(1, 2, 3, 4, 5)];
        expected = ListNode.FromArray(1, 1, 2, 3, 4, 4, 5, 5);
        Assert.IsTrue(ListNode.CompareListNodeEquivalent(expected, solution.MergeKLists(lists)));
    }

    [TestMethod]
    public void TestSolution_WhenZeroListNode_ShouldReturnNull()
    {
        Solution solution = new();
        ListNode?[] lists = [];
        Assert.IsNull(solution.MergeKLists(lists));
    }

    [TestMethod]
    public void TestSolution_WhenOnlyNullListNode_ShouldReturnNull()
    {
        Solution solution = new();
        ListNode?[] lists = [null, null];
        Assert.IsNull(solution.MergeKLists(lists));
    }
}