using JetBrains.Annotations;
using source._2900._2965;

namespace test._2900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2965
{
    [TestMethod]
    public void normal_case()
    {
        int[][] grid = new[]
        {
            new[] { 1, 3 },
            new[] { 2, 2 },
        };
        int[] expected = new[] { 2, 4 };
        int[] actual = new Solution().FindMissingAndRepeatedValues(grid);
        CollectionAssert.AreEquivalent(expected, actual);

        grid = new[]
        {
            new[] { 9, 1, 7 },
            new[] { 8, 9, 2 },
            new[] { 3, 4, 6 },
        };
        expected = new[] { 9, 5 };
        actual = new Solution().FindMissingAndRepeatedValues(grid);
        CollectionAssert.AreEquivalent(expected, actual);
    }
}