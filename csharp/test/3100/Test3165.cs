using JetBrains.Annotations;
using source._3100._3165;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3165
{
    private Solution _solution = new();

    [TestMethod]
    public void TestSoution_TestCase()
    {
        int[] nums = [3, 5, 9];
        int[][] queries = [[1, -2], [0, -3]];
        Assert.AreEqual(21, _solution.MaximumSumSubsequence(nums, queries));

        nums = [0, -1];
        queries = [[0, -5]];
        Assert.AreEqual(0, _solution.MaximumSumSubsequence(nums, queries));
    }
}