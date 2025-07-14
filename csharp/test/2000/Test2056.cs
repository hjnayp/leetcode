using JetBrains.Annotations;
using source._2000._2056;

namespace test._2000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2056
{
    private readonly Solution solution = new();
    private string[] pieces;
    private int[][] positions;
    private int expected;

    [TestMethod]
    public void TestSolution()
    {
        pieces = ["rook"];
        positions = [[1, 1]];
        expected = 15;
        Assert.AreEqual(expected, solution.CountCombinations(pieces, positions));

        pieces = ["queen"];
        positions = [[1, 1]];
        expected = 22;
        Assert.AreEqual(expected, solution.CountCombinations(pieces, positions));

        pieces = ["bishop"];
        positions = [[4, 3]];
        expected = 12;
        Assert.AreEqual(expected, solution.CountCombinations(pieces, positions));

        pieces = ["rook", "rook"];
        positions = [[1, 1], [8, 8]];
        expected = 223;
        Assert.AreEqual(expected, solution.CountCombinations(pieces, positions));
    }
}