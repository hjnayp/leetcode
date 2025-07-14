using JetBrains.Annotations;
using source._1900._1969;

namespace test._1900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1969
{
    private static Solution s_ProblemSolution = new();

    private static void TestRunner(int p, int expected)
    {
        Assert.AreEqual(expected, s_ProblemSolution.MinNonZeroProduct(p));
    }

    [TestMethod]
    public void NormalCases()
    {
        TestRunner(1, 1);
        TestRunner(2, 6);
        TestRunner(3, 1512);
    }
}