using JetBrains.Annotations;
using source._3300._3372;

namespace test._3300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3372
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int[][] edges1 = [[0, 1]];
        int[][] edges2 = [[0, 1]];
        int k = 0;

        int[] expected = [1, 1];
        int[] actual = solution.MaxTargetNodes(edges1, edges2, 0);
        CollectionAssert.AreEqual(expected, actual);
    }
}