using JetBrains.Annotations;
using source._0700._724;

namespace test._0700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Teset724
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        int[] nums = [1, 7, 3, 6, 5, 6];
        Assert.AreEqual(3, solution.PivotIndex(nums));

        nums = [1, 2, 3];
        Assert.AreEqual(-1, solution.PivotIndex(nums));

        nums = [2, 1, -1];
        Assert.AreEqual(0, solution.PivotIndex(nums));
    }
}