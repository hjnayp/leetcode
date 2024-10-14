using JetBrains.Annotations;
using source._0000._41;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test41
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();
        int[] nums = [1, 2, 0];
        int expected = 3;
        Assert.AreEqual(expected, solution.FirstMissingPositive(nums));

        nums = [3, 4, -1, 1];
        expected = 2;
        Assert.AreEqual(expected, solution.FirstMissingPositive(nums));

        nums = [7, 8, 9, 11, 12];
        expected = 1;
        Assert.AreEqual(expected, solution.FirstMissingPositive(nums));
    }
}