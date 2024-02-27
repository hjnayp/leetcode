using source._2800._2867;

namespace test._2800;

[TestClass]
public class Test2867
{
    [TestMethod]
    public void NormalCase()
    {
        var n = 5;
        var solution = new Solution();
        int[][] edges =
        {
            new[] { 1, 2 },
            new[] { 1, 3 },
            new[] { 2, 4 },
            new[] { 2, 5 },
        };

        long result = solution.CountPaths(n, edges);
        Assert.AreEqual(4, result);

        edges = new[]
        {
            new[] { 1, 2 },
            new[] { 1, 3 },
            new[] { 2, 4 },
            new[] { 3, 5 },
            new[] { 3, 6 },
        };
        n = 6;
        result = solution.CountPaths(n, edges);
        Assert.AreEqual(6, result);

        edges = new[]
        {
            new[] { 1, 2 },
            new[] { 4, 1 },
            new[] { 3, 4 },
        };
        n = 4;
        result = solution.CountPaths(n, edges);
        Assert.AreEqual(4, result);
    }
}