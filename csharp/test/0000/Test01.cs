using JetBrains.Annotations;
using source._0000._01;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test01
{
    [TestMethod]
    [Timeout(1500)]
    public void NormalCase()
    {
        Solution solution = new();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] expected = { 0, 1 };
        int[]? actual = solution.TwoSum(nums, target);
        CollectionAssert.AreEqual(expected, actual);

        nums = new[] { 3, 2, 4 };
        target = 6;
        expected = new[] { 1, 2 };
        actual = solution.TwoSum(nums, target);
        CollectionAssert.AreEqual(expected, actual);

        nums = new[] { 3, 3 };
        target = 6;
        expected = new[] { 0, 1 };
        actual = solution.TwoSum(nums, target);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void NoSolutionCase()
    {
        Solution solution = new();
        int[] nums = { 2, 7, 11, 15 };
        int target = 100;
        int[] expected = Array.Empty<int>();
        int[]? actual = solution.TwoSum(nums, target);
        CollectionAssert.AreEqual(expected, actual);
    }
}