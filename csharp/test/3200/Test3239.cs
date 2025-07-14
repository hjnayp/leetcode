using JetBrains.Annotations;
using source._3200._3239;

namespace test._3200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3239
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();

        int[][] grid;

        grid = [[1, 0, 0], [0, 0, 0], [0, 0, 1]];
        Assert.AreEqual(2, solution.MinFlips(grid));

        grid = [[0, 1], [0, 1], [0, 0]];
        Assert.AreEqual(1, solution.MinFlips(grid));

        grid = [[1], [0]];
        Assert.AreEqual(0, solution.MinFlips(grid));
    }
}