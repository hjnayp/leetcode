using JetBrains.Annotations;
using source._3000._3011;

namespace test._3000;

[TestClass, TestSubject(typeof(Solution))]
public class Test3011
{
    [TestMethod]
    public void true_case()
    {
        var solution = new Solution();

        int[] nums = [8, 4, 2, 30, 15];
        Assert.IsTrue(solution.CanSortArray(nums));

        nums = [1, 2, 3, 4, 5];
        Assert.IsTrue(solution.CanSortArray(nums));
    }

    [TestMethod]
    public void false_case()
    {
        var solution = new Solution();

        int[] nums = [3, 16, 8, 4, 2];
        Assert.IsFalse(solution.CanSortArray(nums));

        nums = [20, 16];
        Assert.IsFalse(solution.CanSortArray(nums));
    }
}