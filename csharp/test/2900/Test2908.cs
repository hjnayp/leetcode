using JetBrains.Annotations;
using source._2900._2908;

namespace test._2900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2908
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var nums = new[] { 8, 6, 1, 5, 3 };
        var expected = 9;
        int actual = solution.MinimumSum(nums);
        Assert.AreEqual(expected, actual);

        nums = new[] { 5, 4, 8, 7, 10, 2 };
        expected = 13;
        actual = solution.MinimumSum(nums);
        Assert.AreEqual(expected, actual);

        nums = new[] { 6, 5, 4, 3, 4, 5 };
        expected = -1;
        actual = solution.MinimumSum(nums);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ExceptionCase()
    {
        var solution = new Solution();
        var nums = new[] { 8, 6 };
        int expected = -1;
        int actual = solution.MinimumSum(nums);
        Assert.AreEqual(expected, actual);
    }
}