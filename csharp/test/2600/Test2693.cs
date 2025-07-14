using JetBrains.Annotations;
using source._2600._2639;

namespace test._2600;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2693
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        int[][] grid =
        {
            new[] { 1 },
            new[] { 22 },
            new[] { 333 }
        };
        int[] expected = { 3 };

        CollectionAssert.AreEquivalent(expected, solution.FindColumnWidth(grid));
    }

    [TestMethod]
    public void NormalCase2()
    {
        var solution = new Solution();
        int[][] grid =
        {
            new[] { -15, 1, 3 },
            new[] { 15, 7, 12 },
            new[] { 5, 6, -2 }
        };
        int[] expected = { 3, 1, 2 };

        CollectionAssert.AreEquivalent(expected, solution.FindColumnWidth(grid));
    }

    [TestMethod]
    public void Zero()
    {
        var solution = new Solution();
        int[][] grid =
        {
            new[] { 0 }
        };
        int[] expected = { 1 };

        CollectionAssert.AreEquivalent(expected, solution.FindColumnWidth(grid));
    }
}