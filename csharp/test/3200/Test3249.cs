using JetBrains.Annotations;
using source._3200._3249;

namespace test._3200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3249
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();
        int[][] edges = [];

        edges = [[1, 0], [3, 0], [2, 3]];
        Assert.AreEqual(3, solution.CountGoodNodes(edges));

        edges = [[0, 1], [0, 2], [1, 3], [1, 4], [2, 5], [2, 6]];
        Assert.AreEqual(7, solution.CountGoodNodes(edges));

        edges = [[0, 1], [1, 2], [2, 3], [3, 4], [0, 5], [1, 6], [2, 7], [3, 8]];
        Assert.AreEqual(6, solution.CountGoodNodes(edges));

        edges = [[0, 1], [1, 2], [1, 3], [1, 4], [0, 5], [5, 6], [6, 7], [7, 8], [0, 9], [9, 10], [9, 12], [10, 11]];
        Assert.AreEqual(12, solution.CountGoodNodes(edges));

        edges = [[6, 0], [1, 0], [5, 1], [2, 5], [3, 1], [4, 3]];
        Assert.AreEqual(6, solution.CountGoodNodes(edges));
    }
}