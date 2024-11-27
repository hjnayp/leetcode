using JetBrains.Annotations;
using source._2900._2906;

namespace test._2900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2906
{
    private Solution solution = new();
    private int[][] grid;
    private int[][] expected;
    private int[][] result;

    [TestMethod]
    public void TestSolution()
    {
        grid = [[1, 2], [3, 4]];
        expected = [[24, 12], [8, 6]];
        result = solution.ConstructProductMatrix(grid);
        for (var i = 0; i < grid.Length; i++)
        {
            CollectionAssert.AreEqual(expected[i], result[i]);
        }

        grid = [[12345], [2], [1]];
        expected = [[2], [0], [0]];
        result = solution.ConstructProductMatrix(grid);
        for (var i = 0; i < grid.Length; i++)
        {
            CollectionAssert.AreEqual(expected[i], result[i]);
        }
    }
}