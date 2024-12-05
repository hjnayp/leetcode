using JetBrains.Annotations;
using source._3200._3238;

namespace test._3200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3238
{
    private Solution solution = new();
    private int[][] pick;
    private int n;
    private int expected;

    [TestMethod]
    public void TestSolution()
    {
        n = 4;
        pick = [[0, 0], [1, 0], [1, 0], [2, 1], [2, 1], [2, 0]];
        expected = 2;
        Assert.AreEqual(expected, solution.WinningPlayerCount(n, pick));

        n = 5;
        pick = [[1, 1], [1, 2], [1, 3], [1, 4]];
        expected = 0;
        Assert.AreEqual(expected, solution.WinningPlayerCount(n, pick));

        n = 5;
        pick = [[1, 1], [2, 4], [2, 4], [2, 4]];
        expected = 1;
        Assert.AreEqual(expected, solution.WinningPlayerCount(n, pick));
    }
}