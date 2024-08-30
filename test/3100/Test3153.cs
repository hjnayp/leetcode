using JetBrains.Annotations;
using source._3100._3153;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3153
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        int[] nums = [13, 23, 12];
        Assert.AreEqual(4, solution.SumDigitDifferences(nums));

        nums = [10, 10, 10, 10];
        Assert.AreEqual(0, solution.SumDigitDifferences(nums));
    }
}