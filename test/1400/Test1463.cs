using JetBrains.Annotations;
using source._1400._1463;

namespace test._1400;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1463
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int[][] grid =
        {
            new[] { 3, 1, 1 },
            new[] { 2, 5, 1 },
            new[] { 1, 5, 5 },
            new[] { 2, 1, 1 }
        };
        Assert.AreEqual(24, solution.CherryPickup(grid));

        grid = new[]
        {
            new[] { 1, 0, 0, 0, 0, 0, 1 },
            new[] { 2, 0, 0, 0, 0, 3, 0 },
            new[] { 2, 0, 9, 0, 0, 0, 0 },
            new[] { 0, 3, 0, 5, 4, 0, 0 },
            new[] { 1, 0, 2, 3, 0, 0, 6 }
        };
        Assert.AreEqual(28, solution.CherryPickup(grid));
    }
}