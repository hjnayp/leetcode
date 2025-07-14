using JetBrains.Annotations;
using source._2300._2316;

namespace test._2300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2316
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var n = 7;
        int[][] edges =
        {
            new[] { 0, 2 },
            new[] { 0, 5 },
            new[] { 2, 4 },
            new[] { 1, 6 },
            new[] { 5, 4 }
        };

        long actual = solution.CountPairs(n, edges);
        var expected = 14;
        Assert.AreEqual(expected, actual);
    }
}