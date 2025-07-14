using JetBrains.Annotations;
using source._3200._3232;

namespace test._3200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3232
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int[] nums = [1, 2, 3, 4, 10];
        Assert.IsFalse(solution.CanAliceWin(nums));

        nums = [1, 2, 3, 4, 5, 14];
        Assert.IsTrue(solution.CanAliceWin(nums));

        nums = [5, 5, 5, 25];
        Assert.IsTrue(solution.CanAliceWin(nums));
    }
}