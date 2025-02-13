using JetBrains.Annotations;
using source._0000._80;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test80
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int[] nums = [1, 1, 1, 2, 2, 3];
        int[] expected = [1, 1, 2, 2, 3];
        int k = solution.RemoveDuplicates(nums);
        AssertIsExpected(expected, nums, k);

        nums = [0, 0, 1, 1, 1, 1, 2, 3, 3];
        expected = [0, 0, 1, 1, 2, 3, 3];
        k = solution.RemoveDuplicates(nums);
        AssertIsExpected(expected, nums, k);

        nums = [1, 1, 1];
        expected = [1, 1];
        k = solution.RemoveDuplicates(nums);
        AssertIsExpected(expected, nums, k);

        nums = [1, 2, 2, 2];
        expected = [1, 2, 2];
        k = solution.RemoveDuplicates(nums);
        AssertIsExpected(expected, nums, k);

        nums = [1, 1, 1, 2, 2, 2, 3, 3];
        expected = [1, 1, 2, 2, 3, 3];
        k = solution.RemoveDuplicates(nums);
        AssertIsExpected(expected, nums, k);
    }

    private void AssertIsExpected(int[] expected, int[] nums, int k)
    {
        Assert.AreEqual(expected.Length, k);
        for (int i = 0; i < expected.Length; i++)
        {
            Assert.AreEqual(expected[i], nums[i]);
        }
    }
}