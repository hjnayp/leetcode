using JetBrains.Annotations;
using source._3200._3244;

namespace test._3200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3244
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();
        int n;
        int[][] queries = [];
        int[] result = [];

        n = 4;
        queries = [[0, 3], [0, 2]];
        result = [1, 1];
        CollectionAssert.AreEqual(result, solution.ShortestDistanceAfterQueries(n, queries));

        n = 5;
        queries = [[2, 4], [0, 2], [0, 4]];
        result = [3, 2, 1];
        CollectionAssert.AreEqual(result, solution.ShortestDistanceAfterQueries(n, queries));
    }

    [TestMethod]
    public void TestSolution2()
    {
        Solution solution = new();
        int n;
        int[][] queries = [];
        int[] result = [];

        n = 6;
        queries = [[3, 5], [2, 5]];
        result = [4, 3];
        CollectionAssert.AreEqual(result, solution.ShortestDistanceAfterQueries(n, queries));
    }
}