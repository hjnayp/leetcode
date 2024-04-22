using JetBrains.Annotations;
using source._0300._377;

namespace test._0300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test377
{
    [TestMethod]
    public void Normal()
    {
        var solution = new Solution();
        var target = 4;
        var nums = new[] { 1, 2, 3 };
        var expected = 7;
        Assert.AreEqual(expected, solution.CombinationSum4(nums, target));
    }

    [TestMethod]
    public void ZeroCombination()
    {
        var solution = new Solution();
        var target = 3;
        var nums = new[] { 9 };
        var expected = 0;
        Assert.AreEqual(expected, solution.CombinationSum4(nums, target));
    }
}