using JetBrains.Annotations;
using source._1600._1671;

namespace test._1600;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1671
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var nums = new[]
        {
            1, 16, 84, 9, 29, 71, 86, 79, 72, 12
        };
        var expected = 2;
        Assert.AreEqual(expected, solution.MinimumMountainRemovals(nums));
    }
}