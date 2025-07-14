using JetBrains.Annotations;
using source._0000._16;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test16
{
    [TestMethod]
    public void NormalCase()
    {
        Solution solution = new();
        int[] nums = [-1, 2, 1, -4];
        int target = 1;
        Assert.AreEqual(2, solution.ThreeSumClosest(nums, target));

        nums = [0, 0, 0];
        target = 1;
        Assert.AreEqual(0, solution.ThreeSumClosest(nums, target));

        nums = [4, 0, 5, -5, 3, 3, 0, -4, -5];
        target = -2;
        Assert.AreEqual(-2, solution.ThreeSumClosest(nums, target));

        nums = [1, 1, 1, 0];
        target = -100;
        Assert.AreEqual(2, solution.ThreeSumClosest(nums, target));

        nums = [1, 1, 1, 1, 1, 1, 1, 1, 1, 0];
        target = -100;
        Assert.AreEqual(2, solution.ThreeSumClosest(nums, target));
    }
}