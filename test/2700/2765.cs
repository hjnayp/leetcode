using source._2700._2765;

namespace test._2700;

[TestClass]
public class Test2765
{
    private Solution _solution = new();

    [TestMethod]
    public void NormalCase()
    {
        var nums = new[] { 2, 3, 4, 3, 4 };
        var expected = 4;
        Assert.AreEqual(expected, _solution.AlternatingSubarray(nums));
    }

    [TestMethod]
    public void InvalidCase()
    {
        var nums = new[] { 21, 9, 5 };
        var expected = -1;
        Assert.AreEqual(expected, _solution.AlternatingSubarray(nums));
    }
}