using source._0000._01;

namespace test._0000;

[TestClass]
public class Test01
{
    [TestMethod]
    [Timeout(1500)]
    public void NormalCase()
    {
        var solution = new Solution();
        var nums = new[] { 2, 7, 11, 15 };
        var target = 9;
        var expected = new[] { 0, 1 };
        var actual = solution.TwoSum(nums, target);
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
}