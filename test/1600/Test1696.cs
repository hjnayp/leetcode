using JetBrains.Annotations;
using source._1600._1696;

namespace test._1600;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1696
{
    [TestMethod]
    public void NormalCase()
    {
        int[] nums = { 1, -5, -20, 4, -1, 3, -6, -3 };
        var k = 2;
        var expected = 0;
        var solution = new Solution();
        int actual = solution.MaxResult(nums, k);
        Assert.AreEqual(expected, actual);
    }
}