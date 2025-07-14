using JetBrains.Annotations;
using source._0000._51;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test51
{
    private Solution solution = new();
    private int n;
    private string[][] expected;
    private IList<IList<string>> result;

    [TestMethod]
    public void TestSolution()
    {
        n = 5;
        expected =
        [
            ["Q....", "..Q..", "....Q", ".Q...", "...Q."],
            ["Q....", "...Q.", ".Q...", "....Q", "..Q.."],
            [".Q...", "...Q.", "Q....", "..Q..", "....Q"],
            [".Q...", "....Q", "..Q..", "Q....", "...Q."],
            ["..Q..", "Q....", "...Q.", ".Q...", "....Q"],
            ["..Q..", "....Q", ".Q...", "...Q.", "Q...."],
            ["...Q.", "Q....", "..Q..", "....Q", ".Q..."],
            ["...Q.", ".Q...", "....Q", "..Q..", "Q...."],
            ["....Q", ".Q...", "...Q.", "Q....", "..Q.."],
            ["....Q", "..Q..", "Q....", "...Q.", ".Q..."],
        ];
        result = solution.SolveNQueens(n);
        for (var i = 0; i < expected.Length; i++)
        {
            CollectionAssert.AreEqual(expected[i], result[i].ToArray());
        }

        n = 4;
        expected = [[".Q..", "...Q", "Q...", "..Q."], ["..Q.", "Q...", "...Q", ".Q.."]];
        result = solution.SolveNQueens(n);
        for (var i = 0; i < expected.Length; i++)
        {
            CollectionAssert.AreEqual(expected[i], result[i].ToArray());
        }

        n = 1;
        expected = [["Q"]];
        result = solution.SolveNQueens(n);
        for (var i = 0; i < expected.Length; i++)
        {
            CollectionAssert.AreEqual(expected[i], result[i].ToArray());
        }
    }
}