using JetBrains.Annotations;
using source._3200._3251;

namespace test._3200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3251
{
    private readonly Solution solution = new();
    private int[] nums;
    private int expected;

    [TestMethod]
    public void TestSolution()
    {
        nums = [2, 3, 2];
        expected = 4;
        Assert.AreEqual(expected, solution.CountOfPairs(nums));

        nums = [5, 5, 5, 5];
        expected = 126;
        Assert.AreEqual(expected, solution.CountOfPairs(nums));
    }
}