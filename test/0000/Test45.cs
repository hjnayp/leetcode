using JetBrains.Annotations;
using source._0000._45;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test45
{
    [TestMethod, Timeout(1000)]
    public void TestSolution()
    {
        Solution solution = new();

        int[] nums = [2, 3, 1, 1, 4];
        Assert.AreEqual(2, solution.Jump(nums));

        nums = [2, 3, 0, 1, 4];
        Assert.AreEqual(2, solution.Jump(nums));
    }
}