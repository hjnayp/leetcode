using JetBrains.Annotations;
using source._0000._52;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test52
{
    private Solution solution = new();
    private int n;
    private int expected;

    [TestMethod]
    public void TestSolution()
    {
        n = 4;
        expected = 2;
        Assert.AreEqual(expected, solution.TotalNQueens(n));

        n = 1;
        expected = 1;
        Assert.AreEqual(expected, solution.TotalNQueens(n));
    }
}