using JetBrains.Annotations;
using source._0100._198;

namespace test._0100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test198
{
    [TestMethod]
    [Timeout(1000)]
    public void TestSolution()
    {
        var solution = new Solution();

        int[] nums = [2, 1, 1, 2];
        Assert.AreEqual(4, solution.Rob(nums));

        nums = [1, 2, 3, 1];
        Assert.AreEqual(4, solution.Rob(nums));

        nums = [2, 7, 9, 3, 1];
        Assert.AreEqual(12, solution.Rob(nums));
    }
}