using JetBrains.Annotations;
using source._0000._25;
using source.Structs;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test25
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        var head = ListNode.FromArray(1, 2, 3, 4, 5);

        var expected = ListNode.FromArray(2, 1, 4, 3, 5);
        Assert.IsTrue(ListNode.AreEquivalent(expected, solution.ReverseKGroup(head, 2)));

        head = ListNode.FromArray(1, 2, 3, 4, 5);
        expected = ListNode.FromArray(3, 2, 1, 4, 5);
        Assert.IsTrue(ListNode.AreEquivalent(expected, solution.ReverseKGroup(head, 3)));
    }

    [TestMethod]
    public void TestSolution_WhenKIsOne_ShouldNotChange()
    {
        var solution = new Solution();
        var head = ListNode.FromArray(1, 2, 3, 4, 5);
        var expected = ListNode.FromArray(1, 2, 3, 4, 5);
        Assert.IsTrue(ListNode.AreEquivalent(expected, solution.ReverseKGroup(head, 1)));
    }
}