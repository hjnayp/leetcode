using JetBrains.Annotations;
using source._2800._2831;

namespace test._2800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2831

{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int[] nums = new[] { 1, 3, 2, 3, 1, 3 };
        int k = 3;
        Assert.AreEqual(3, solution.LongestEqualSubarray(nums, k));

        nums = new[] { 1, 1, 2, 2, 1, 1 };
        k = 2;
        Assert.AreEqual(4, solution.LongestEqualSubarray(nums, k));
    }

    [TestMethod]
    public void only_one_number()
    {
        var solution = new Solution();
        int[] nums = new[] { 1 };
        int k = 0;
        Assert.AreEqual(1, solution.LongestEqualSubarray(nums, k));

        nums = new[] { 2 };
        k = 1;
        Assert.AreEqual(1, solution.LongestEqualSubarray(nums, k));
    }

    [TestMethod]
    public void only_one_number_different()
    {
        var solution = new Solution();
        int[] nums = new[] { 4, 4, 4, 3, 4 };
        int k = 1;
        Assert.AreEqual(4, solution.LongestEqualSubarray(nums, k));
    }

    [TestMethod]
    public void k_is_zero()
    {
        var solution = new Solution();
        int[] nums = new[] { 1, 2, 3, 4, 5 };
        int k = 0;
        Assert.AreEqual(1, solution.LongestEqualSubarray(nums, k));

        nums = new[] { 1, 1, 1, 1, 1 };
        k = 0;
        Assert.AreEqual(5, solution.LongestEqualSubarray(nums, k));

        nums = new[] { 1, 1, 1, 2, 1 };
        k = 0;
        Assert.AreEqual(3, solution.LongestEqualSubarray(nums, k));
    }
}