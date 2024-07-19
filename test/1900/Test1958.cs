using JetBrains.Annotations;
using source._1900._1958;

namespace test._1900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1958
{
    [TestMethod]
    public void true_case_1()
    {
        Solution solution = new();
        char[][] board =
        [
            ['.', '.', '.', 'B', '.', '.', '.', '.'], ['.', '.', '.', 'W', '.', '.', '.', '.'],
            ['.', '.', '.', 'W', '.', '.', '.', '.'], ['.', '.', '.', 'W', '.', '.', '.', '.'],
            ['W', 'B', 'B', '.', 'W', 'W', 'W', 'B'], ['.', '.', '.', 'B', '.', '.', '.', '.'],
            ['.', '.', '.', 'B', '.', '.', '.', '.'], ['.', '.', '.', 'W', '.', '.', '.', '.']
        ];
        int rMove = 4;
        int cMove = 3;
        char color = 'B';
        Assert.IsTrue(solution.CheckMove(board, rMove, cMove, color));
    }

    [TestMethod]
    public void true_case_2()
    {
        Solution solution = new();
        char[][] board =
        [
            ['.', '.', 'W', '.', 'B', 'W', 'W', 'B'],
            ['B', 'W', '.', 'W', '.', 'W', 'B', 'B'],
            ['.', 'W', 'B', 'W', 'W', '.', 'W', 'W'], 
            ['W', 'W', '.', 'W', '.', '.', 'B', 'B'],
            ['B', 'W', 'B', 'B', 'W', 'W', 'B', '.'], 
            ['W', '.', 'W', '.', '.', 'B', 'W', 'W'],
            ['B', '.', 'B', 'B', '.', '.', 'B', 'B'],
            ['.', 'W', '.', 'W', '.', 'W', '.', 'W']
        ];
        int rMove = 5;
        int cMove = 4;
        char color = 'W';
        Assert.IsTrue(solution.CheckMove(board, rMove, cMove, color));
    }

    [TestMethod]
    public void false_case_1()
    {
        Solution solution = new();
        char[][] board =
        [
            ['.', '.', '.', '.', '.', '.', '.', '.'], ['.', 'B', '.', '.', 'W', '.', '.', '.'],
            ['.', '.', 'W', '.', '.', '.', '.', '.'], ['.', '.', '.', 'W', 'B', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.'], ['.', '.', '.', '.', 'B', 'W', '.', '.'],
            ['.', '.', '.', '.', '.', '.', 'W', '.'], ['.', '.', '.', '.', '.', '.', '.', 'B']
        ];
        int rMove = 4;
        int cMove = 4;
        char color = 'W';
        Assert.IsFalse(solution.CheckMove(board, rMove, cMove, color));
    }
}