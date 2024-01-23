using source._1600._1631;

namespace test._1600;

[TestClass]
public class Test1631
{
    [TestMethod]
    [Timeout(1500)]
    public void NormalCase()
    {
        var solution = new Solution();
        var heights = new[]
        {
            new[] { 1, 2, 2 },
            new[] { 3, 8, 2 },
            new[] { 5, 3, 5 },
        };
        var expected = 2;
        Assert.AreEqual(expected, solution.MinimumEffortPath(heights));

        heights = new[]
        {
            new[] { 1, 2, 3 },
            new[] { 3, 8, 4 },
            new[] { 5, 3, 5 },
        };
        expected = 1;
        Assert.AreEqual(expected, solution.MinimumEffortPath(heights));

        heights = new[]
        {
            new[] { 1, 2, 1, 1, 1 },
            new[] { 1, 2, 1, 2, 1 },
            new[] { 1, 2, 1, 2, 1 },
            new[] { 1, 2, 1, 2, 1 },
            new[] { 1, 1, 1, 2, 1 },
        };
        expected = 0;
        Assert.AreEqual(expected, solution.MinimumEffortPath(heights));
    }
}