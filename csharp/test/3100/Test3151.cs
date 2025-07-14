using JetBrains.Annotations;
using source._3100._3151;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3151
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();

        int[] nums = [1];
        Assert.IsTrue(solution.IsArraySpecial(nums));

        nums = [2, 1, 4];
        Assert.IsTrue(solution.IsArraySpecial(nums));

        nums = [4, 3, 1, 6];
        Assert.IsFalse(solution.IsArraySpecial(nums));
    }
}