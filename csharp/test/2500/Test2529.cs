using JetBrains.Annotations;
using source._2500._2529;

namespace test._2500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2529
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        int[] nums = { -2, -1, -1, 1, 2, 3 };
        Assert.AreEqual(3, solution.MaximumCount(nums));

        nums = new[] { 1, 1, 1, 1, 1 };
        Assert.AreEqual(5, solution.MaximumCount(nums));

        nums = new[] { -3, -2, -1, 0, 0, 1, 2 };
        Assert.AreEqual(3, solution.MaximumCount(nums));

        nums = new[] { 5, 20, 66, 1314 };
        Assert.AreEqual(4, solution.MaximumCount(nums));
    }
}