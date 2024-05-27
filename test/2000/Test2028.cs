using JetBrains.Annotations;
using source._2000._2028;

namespace test._2000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2028
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int[] nums = new[] { 3, 2, 4, 3 };
        int mean = 4;
        int n = 2;
        int[] expected = new[] { 6, 6 };
        int[] result = solution.MissingRolls(nums, mean, n);
        Assert.AreEqual(expected.Length, result.Length);
        Assert.AreEqual(expected.Sum(), result.Sum());

        nums = new[] { 1, 5, 6 };
        mean = 3;
        n = 4;
        expected = new[] { 2, 3, 2, 2 };
        result = solution.MissingRolls(nums, mean, n);
        Assert.AreEqual(expected.Length, result.Length);
        Assert.AreEqual(expected.Sum(), result.Sum());
    }

    [TestMethod]
    public void impossible_case()
    {
        var solution = new Solution();
        int[] nums = new int[] { 1, 2, 3, 4 };
        int mean = 6;
        int n = 4;
        int[] expected = Array.Empty<int>();
        int[] result = solution.MissingRolls(nums, mean, n);
        Assert.AreEqual(expected.Length, result.Length);
        Assert.AreEqual(expected.Sum(), result.Sum());
    }
}