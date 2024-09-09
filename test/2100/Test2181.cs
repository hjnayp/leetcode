using JetBrains.Annotations;
using source._2100;
using source.Structs;

namespace test._2100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2181
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        var head = ListNode.FromArray(0, 3, 1, 0, 4, 5, 2, 0);
        var expected = ListNode.FromArray(4, 11);
        Assert.IsTrue(ListNode.AreEquivalent(expected, solution.MergeNodes(head)));
        
        head = ListNode.FromArray(0,1,0,3,0,2,2,0);
        expected = ListNode.FromArray(1, 3, 4);
        Assert.IsTrue(ListNode.AreEquivalent(expected, solution.MergeNodes(head)));
    }
}