using JetBrains.Annotations;
using source._1000._1014;

namespace test._1000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1014
{
    [TestMethod]
    public void TestSolution()
    {
        RunTestCase(11, [8, 1, 5, 2, 6]);
        RunTestCase(2, [1, 2]);
    }

    private static void RunTestCase(int expected, int[] values)
    {
        Solution solution = new();
        Assert.AreEqual(expected, solution.MaxScoreSightseeingPair(values));
    }
}