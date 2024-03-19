using JetBrains.Annotations;
using source._1700._1793;

namespace test._1700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1793
{

    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        int[] nums = { 1, 4, 3, 7, 4, 5 };
        var k = 3;
        var expected = 15;
        int actual = solution.MaximumScore(nums, k);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void NormalCase2()
    {
        var solution = new Solution();
        int[] nums = { 5, 5, 4, 5, 4, 1, 1, 1 };
        var k = 0;
        var expected = 20;
        int actual = solution.MaximumScore(nums, k);
        Assert.AreEqual(expected, actual);
    }
}