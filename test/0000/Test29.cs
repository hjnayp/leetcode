using JetBrains.Annotations;
using source._0000._29;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test29
{
    private static readonly Solution SolutionIns = new();

    [TestMethod]
    public void TestSolution()
    {
        RunTest(10, 3);
        RunTest(7, -3);
        RunTest(-7, -3);
        RunTest(2147483647, 1);
        RunTest(0, 1);
        RunTest(int.MaxValue, 1);
        RunTest(int.MinValue, -1, int.MaxValue);
        RunTest(int.MinValue, 1);
        RunTest(1, int.MinValue, 0);
        RunTest(int.MinValue, int.MinValue);
    }

    private static void RunTest(int dividend, int divisor, int? expected = null)
    {
        Assert.AreEqual(expected ?? dividend / divisor, SolutionIns.Divide(dividend, divisor));
    }
}