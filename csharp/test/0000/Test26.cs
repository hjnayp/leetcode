using JetBrains.Annotations;
using source._0000._26;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test26
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int[] nums = [1, 2, 2];
        int k = solution.RemoveDuplicates(nums);
        Assert.AreEqual(2, k);
        int[] expected = [1, 2];
        CollectionAssert.AreEqual(expected, nums.Take(2).ToArray());

        nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
        k = solution.RemoveDuplicates(nums);
        Assert.AreEqual(5, k);
        expected = [0, 1, 2, 3, 4];
        CollectionAssert.AreEqual(expected, nums.Take(5).ToArray());
    }

    [TestMethod]
    public void TestSolution_WhenOnlyOneNumber_ShouldReturnSelf()
    {
        var solution = new Solution();
        int[] nums = [1];
        int k = solution.RemoveDuplicates(nums);
        Assert.AreEqual(nums.Length, k);
        int[] expected = [1];
        CollectionAssert.AreEqual(expected, nums.Take(nums.Length).ToArray());
    }
}