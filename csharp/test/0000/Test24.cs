using JetBrains.Annotations;
using source._0000._24;
using source.Structs;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test24
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();
        ListNode? head = ListNode.FromArray(1, 2, 3, 4);
        ListNode? expected = ListNode.FromArray(2, 1, 4, 3);
        Assert.IsTrue(ListNode.AreEquivalent(expected, solution.SwapPairs(head)));

        head = ListNode.FromArray(1, 2, 3);
        expected = ListNode.FromArray(2, 1, 3);
        Assert.IsTrue(ListNode.AreEquivalent(expected, solution.SwapPairs(head)));
    }

    [TestMethod]
    public void TestSolution_WhenHeadIsNull_ShouldReturnNull()
    {
        Solution solution = new();
        Assert.IsNull(solution.SwapPairs(null));
    }

    [TestMethod]
    public void TestSolution_WhenHeadHasOneNode_ShouldReturnHead()
    {
        Solution solution = new();
        ListNode? head = ListNode.FromArray(1);
        Assert.IsTrue(ListNode.AreEquivalent(head, solution.SwapPairs(head)));
    }
}