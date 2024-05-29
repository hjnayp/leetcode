using JetBrains.Annotations;
using source._2200._2289;

namespace test._2200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2289
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int[] nums = new[] { 5, 3, 4, 4, 7, 3, 6, 11, 8, 5, 11 };
        Assert.AreEqual(3, solution.TotalSteps(nums));

        nums = new[] { 4, 5, 7, 7, 13 };
        Assert.AreEqual(0, solution.TotalSteps(nums));

        nums = new[] { 10, 1, 2, 3, 4, 5, 6, 1, 2, 3 };
        Assert.AreEqual(6, solution.TotalSteps(nums));

        nums = new[] { 10, 6, 5, 10, 15 };
        Assert.AreEqual(1, solution.TotalSteps(nums));

        nums = new[] { 7, 11, 1 };
        Assert.AreEqual(1, solution.TotalSteps(nums));

        nums = new[] { 5, 14, 15, 2, 11, 5, 13, 15 };
        Assert.AreEqual(3, solution.TotalSteps(nums));
    }
}