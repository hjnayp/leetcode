using JetBrains.Annotations;
using source._3100._3128;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3128
{
    private readonly Solution _solution = new();

    [TestMethod]
    public void NormalCase()
    {
        int[][] grid = [[0, 1, 0], [0, 1, 1], [0, 1, 0]];
        Assert.AreEqual(2, _solution.NumberOfRightTriangles(grid));

        grid = [[1, 0, 1], [1, 0, 0], [1, 0, 0]];
        Assert.AreEqual(2, _solution.NumberOfRightTriangles(grid));
    }

    [TestMethod]
    public void ZeroCase()
    {
        int[][] grid = [[1, 0, 0, 0], [0, 1, 0, 1], [1, 0, 0, 0]];
        Assert.AreEqual(0, _solution.NumberOfRightTriangles(grid));
    }
}