using JetBrains.Annotations;
using source._3200._3205;

namespace test._3200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3250
{
    private Solution solution = new();
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