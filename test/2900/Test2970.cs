using JetBrains.Annotations;
using source._2900._2970;

namespace test._2900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2970
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();

        int[] nums = [1, 2, 3, 4];
        Assert.AreEqual(10, solution.IncremovableSubarrayCount(nums));

        nums = [6, 5, 7, 8];
        Assert.AreEqual(7, solution.IncremovableSubarrayCount(nums));

        nums = [8, 7, 6, 6];
        Assert.AreEqual(3, solution.IncremovableSubarrayCount(nums));

        nums = [3, 5, 3, 5];
        Assert.AreEqual(6, solution.IncremovableSubarrayCount(nums));
    }
}