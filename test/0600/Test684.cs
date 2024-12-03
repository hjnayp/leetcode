using JetBrains.Annotations;
using source._0600._684;

namespace test._0600;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test684
{
    private Solution solution = new();
    private int[][] edges;
    private int[] expected;

    [TestMethod]
    public void TestSolution()
    {
        edges = [[1, 2], [1, 3], [2, 3]];
        expected = [2, 3];
        CollectionAssert.AreEqual(expected, solution.FindRedundantConnection(edges));

        edges = [[1, 2], [2, 3], [3, 4], [1, 4], [1, 5]];
        expected = [1, 4];
        CollectionAssert.AreEqual(expected, solution.FindRedundantConnection(edges));

        edges = [[9, 10], [5, 8], [2, 6], [1, 5], [3, 8], [4, 9], [8, 10], [4, 10], [6, 8], [7, 9]];
        expected = [4, 10];
        CollectionAssert.AreEqual(expected, solution.FindRedundantConnection(edges));
    }
}