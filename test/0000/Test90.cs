using JetBrains.Annotations;
using source._0000._90;
using test.AssertHelpers;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test90
{
    [TestMethod]
    [Timeout(1000)]
    public void TestSolution()
    {
        var solution = new Solution();
        int[] nums = [1, 2, 2];
        int[][] output = [[], [1], [1, 2], [1, 2, 2], [2], [2, 2]];

        var res = solution.SubsetsWithDup(nums);
        TwoDimensionalArrayAssert.AreEquivalent(output, res);

        nums = [0];
        output = [[], [0]];
        res = solution.SubsetsWithDup(nums);
        TwoDimensionalArrayAssert.AreEquivalent(output, res);
    }
}