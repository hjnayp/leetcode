using JetBrains.Annotations;
using source._2500._2535;

namespace test._2500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2535
{
    [TestMethod]
    [Timeout(1000)]
    public void TestSolution()
    {
        RunTestCase(9, [1, 15, 6, 3]);
        RunTestCase(0, [1, 2, 3, 4]);
    }

    private static void RunTestCase(int expected, int[] nums)
    {
        var solution = new Solution();
        Assert.AreEqual(expected, solution.DifferenceOfSum(nums));
    }
}