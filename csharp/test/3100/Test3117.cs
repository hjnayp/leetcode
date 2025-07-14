using JetBrains.Annotations;
using source._3100._3117;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3117
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        int[] nums = [1, 4, 3, 3, 2];
        int[] andValues = [0, 3, 3, 2];
        Assert.AreEqual(12, solution.MinimumValueSum(nums, andValues));

        nums = [2, 3, 5, 7, 7, 7, 5];
        andValues = [0, 7, 5];
        Assert.AreEqual(17, solution.MinimumValueSum(nums, andValues));

        nums = [1, 2, 3, 4];
        andValues = [2];
        Assert.AreEqual(-1, solution.MinimumValueSum(nums, andValues));
    }
}