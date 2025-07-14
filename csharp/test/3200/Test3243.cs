using JetBrains.Annotations;
using source._3200._3243;

namespace test._3200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3243
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();
        int n;
        int[][] queries = [];
        int[] result = [];

        n = 5;
        queries = [[2, 4], [0, 2], [0, 4]];
        result = [3, 2, 1];
        CollectionAssert.AreEqual(result, solution.ShortestDistanceAfterQueries(n, queries));

        n = 4;
        queries = [[0, 3], [0, 2]];
        result = [1, 1];
        CollectionAssert.AreEqual(result, solution.ShortestDistanceAfterQueries(n, queries));
    }
}