using JetBrains.Annotations;
using source._3100._3180;

namespace test._3180;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3180
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int[] rewardValues = [1, 1, 3, 3];
        int output = 4;
        Assert.AreEqual(output, solution.MaxTotalReward(rewardValues));

        rewardValues = [1, 6, 4, 3, 2];
        output = 11;
        Assert.AreEqual(output, solution.MaxTotalReward(rewardValues));
    }
}