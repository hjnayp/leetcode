using source._0300._315;
using test.AssertHelpers;

namespace test._0300;

[TestClass]
public class Test315
{
    [TestMethod]
    [Timeout(1000)]
    public void TestSolution()
    {
        var solution = new Solution();
        int[] nums = [5, 2, 6, 1];
        int[] expected = [2, 1, 1, 0];

        IList<int> actual = solution.CountSmaller(nums);

        ArrayLikeAssertHelper<int>.AreEqual(expected, actual);
    }
}