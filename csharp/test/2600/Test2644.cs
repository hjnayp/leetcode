using JetBrains.Annotations;
using source._2600._2644;

namespace test._2600;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2644
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int[] nums = { 4, 7, 9, 3, 9 };
        int[] divisors = { 5, 2, 3 };
        Assert.AreEqual(3, solution.MaxDivScore(nums, divisors));

        nums = new[] { 20, 14, 21, 10 };
        divisors = new[] { 5, 7, 5 };
        Assert.AreEqual(5, solution.MaxDivScore(nums, divisors));

        nums = new[] { 12 };
        divisors = new[] { 10, 16 };
        Assert.AreEqual(10, solution.MaxDivScore(nums, divisors));
    }
}