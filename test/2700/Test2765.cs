using JetBrains.Annotations;
using source._2700._2765;

namespace test._2700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2765
{
    private readonly Solution _solution = new();

    [TestMethod]
    public void NormalCase()
    {
        int[]? nums = new[] { 2, 3, 4, 3, 4 };
        int expected = 4;
        Assert.AreEqual(expected, _solution.AlternatingSubarray(nums));
    }

    [TestMethod]
    public void InvalidCase()
    {
        int[]? nums = new[] { 21, 9, 5 };
        int expected = -1;
        Assert.AreEqual(expected, _solution.AlternatingSubarray(nums));
    }
}