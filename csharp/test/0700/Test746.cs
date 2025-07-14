using JetBrains.Annotations;
using source._0700._746;

namespace test._0700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test746
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        int[]? input = new[] { 10, 15, 20 };
        int expected = 15;
        Assert.AreEqual(expected, solution.MinCostClimbingStairs(input));

        input = new[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
        expected = 6;
        Assert.AreEqual(expected, solution.MinCostClimbingStairs(input));
    }
}