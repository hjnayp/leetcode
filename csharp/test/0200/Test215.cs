using JetBrains.Annotations;
using source._0200._215;

namespace test._0200;

[TestClass, TestSubject(typeof(Solution))]
public class Test215
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int[] nums = { 3, 2, 1, 5, 6, 4 };
        int k = 2;
        Assert.AreEqual(5, solution.FindKthLargest(nums, k));

        nums = new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
        k = 4;
        Assert.AreEqual(4, solution.FindKthLargest(nums, k));
    }
}