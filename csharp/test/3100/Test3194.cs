using JetBrains.Annotations;
using source._3100._3194;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3194
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();

        int[] nums = [7, 8, 3, 4, 15, 13, 4, 1];
        Assert.AreEqual(5.5, solution.MinimumAverage(nums));

        nums = [1, 9, 8, 3, 10, 5];
        Assert.AreEqual(5.5, solution.MinimumAverage(nums));

        nums = [1, 2, 3, 7, 8, 9];
        Assert.AreEqual(5, solution.MinimumAverage(nums));
    }
}