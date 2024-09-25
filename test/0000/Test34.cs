using source._0000._34;

namespace test._0000;

[TestClass]
public class Test34
{
    private static Solution _solution;

    [TestInitialize]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [TestMethod]
    [Timeout(1000)]
    public void TestSolution()
    {
        RunCase([3, 4], [5, 7, 7, 8, 8, 10], 8);
        RunCase([-1, -1], [5, 7, 7, 8, 8, 10], 6);
        RunCase([-1, -1], [], 0);
    }

    [Timeout(1000)]
    private static void RunCase(int[] expected, int[] nums, int target)
    {
        CollectionAssert.AreEqual(expected, _solution.SearchRange(nums, target));
    }
}