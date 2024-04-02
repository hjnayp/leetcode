using JetBrains.Annotations;
using source._0400._410;

namespace test._0400;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test418
{
    [TestMethod]
    public void TestCase1()
    {
        var solution = new Solution();

        var nums = new[] { 7, 2, 5, 10, 8 };
        var k = 2;
        var expected = 18;
        Assert.AreEqual(expected, solution.SplitArray(nums, k));

        nums = new[] { 1, 4, 4 };
        k = 3;
        expected = 4;
        Assert.AreEqual(expected, solution.SplitArray(nums, k));
    }
}