using JetBrains.Annotations;
using source._0900._908;

namespace test._0900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test908
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();

        int[] nums;
        int k;

        nums = [1];
        k = 0;
        Assert.AreEqual(0, solution.SmallestRangeI(nums, k));

        nums = [2, 4, 6];
        k = 3;
        Assert.AreEqual(0, solution.SmallestRangeI(nums, k));

        nums = [1, 10];
        k = 1;
        Assert.AreEqual(7, solution.SmallestRangeI(nums, k));
    }
}