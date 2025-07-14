using JetBrains.Annotations;
using source._2900._2931;

namespace test._2900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2931
{
    private Solution solution = new();

    [TestMethod]
    public void TestSolution()
    {
        int[][] values = [[8, 5, 2], [6, 4, 1], [9, 7, 3]];
        int expected = 285;
        Assert.AreEqual(expected, solution.MaxSpending(values));

        values = [[10, 8, 6, 4, 2], [9, 7, 5, 3, 2]];
        expected = 386;
        Assert.AreEqual(expected, solution.MaxSpending(values));
    }
}