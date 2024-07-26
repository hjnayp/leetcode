using JetBrains.Annotations;
using source._2700._2740;

namespace test._2700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2740
{
    [TestMethod]
    public void normal_case_0()
    {
        Solution solution = new();
        int[] nums = [1, 3, 2, 4];
        Assert.AreEqual(1, solution.FindValueOfPartition(nums));

        nums = [100, 1, 10];
        Assert.AreEqual(9, solution.FindValueOfPartition(nums));
    }
}