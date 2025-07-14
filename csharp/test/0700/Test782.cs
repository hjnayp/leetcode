using JetBrains.Annotations;
using source._0700._782;

namespace test._0700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test782
{
    private Solution solution = new();
    private int[][] board;
    private int expected;

    [TestMethod]
    public void TestSolution()
    {
        board = [[0, 1, 1, 0], [0, 1, 1, 0], [1, 0, 0, 1], [1, 0, 0, 1]];
        expected = 2;
        Assert.AreEqual(expected, solution.MovesToChessboard(board));

        board = [[0, 1], [1, 0]];
        expected = 0;
        Assert.AreEqual(expected, solution.MovesToChessboard(board));

        board = [[1, 0], [1, 0]];
        expected = -1;
        Assert.AreEqual(expected, solution.MovesToChessboard(board));
    }
}