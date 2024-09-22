using JetBrains.Annotations;
using source._0900._997;

namespace test._0900;

[TestClass, TestSubject(typeof(Solution))]
public class Test997
{
    [TestMethod]
    public void TestSolution_WhenNoJudge_ShouldReturnMinusOne()
    {
        RunTestCase(-1, 3, [[1, 3], [2, 3], [3, 1]]);
        RunTestCase(-1, 3, [[1, 2]]);
    }

    [TestMethod]
    public void TestSolution_WhenCommonCase()
    {
        RunTestCase(2, 2, [[1, 2]]);
        RunTestCase(3, 3, [[1, 3], [2, 3]]);
        RunTestCase(1, 1, []);
    }

    private static void RunTestCase(int expected, int n, int[][] trust)
    {
        Solution solution = new();
        Assert.AreEqual(expected, solution.FindJudge(n, trust));
    }
}