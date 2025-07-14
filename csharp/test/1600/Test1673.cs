using JetBrains.Annotations;
using source._1600._1673;

namespace test._1600;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1673
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int[] nums = { 3, 5, 2, 6 };
        int k = 2;
        int[] expected = { 2, 6 };
        CollectionAssert.AreEquivalent(expected, solution.MostCompetitive(nums, k));

        nums = new[] { 2, 4, 3, 3, 5, 4, 9, 6 };
        k = 4;
        expected = new[] { 2, 3, 3, 4 };
        CollectionAssert.AreEquivalent(expected, solution.MostCompetitive(nums, k));

        nums = new[] { 71, 18, 52, 29, 55, 73, 24, 42, 66, 8, 80, 2 };
        k = 3;
        expected = new[] { 8, 80, 2 };
        CollectionAssert.AreEquivalent(expected, solution.MostCompetitive(nums, k));

        nums = new[]
        {
            84, 10, 71, 23, 66, 61, 62, 64, 34, 41, 80, 25, 91, 43, 4, 75, 65, 13, 37, 41, 46, 90, 55, 8, 85, 61, 95, 71
        };
        k = 24;
        expected = new[]
            { 10, 23, 61, 62, 34, 41, 80, 25, 91, 43, 4, 75, 65, 13, 37, 41, 46, 90, 55, 8, 85, 61, 95, 71 };
        CollectionAssert.AreEquivalent(expected, solution.MostCompetitive(nums, k));
    }
}