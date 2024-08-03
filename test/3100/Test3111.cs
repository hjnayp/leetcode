using JetBrains.Annotations;
using source._3100._3111;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3111
{
    private readonly Solution _solution = new();

    [TestMethod]
    public void CommonCases()
    {
        int[][] points = [[2, 1], [1, 0], [1, 4], [1, 8], [3, 5], [4, 6]];
        Assert.AreEqual(2, _solution.MinRectanglesToCoverPoints(points, 1));

        points = [[0, 0], [1, 1], [2, 2], [3, 3], [4, 4], [5, 5], [6, 6]];
        Assert.AreEqual(3, _solution.MinRectanglesToCoverPoints(points, 2));
    }

    [TestMethod]
    public void ZeroWidthCase()
    {
        int[][] points = [[0, 0], [1, 1], [2, 2], [3, 3], [4, 4], [5, 5], [6, 6]];
        Assert.AreEqual(7, _solution.MinRectanglesToCoverPoints(points, 0));

        points = [[0, 1], [0, 2], [0, 3]];
        Assert.AreEqual(1, _solution.MinRectanglesToCoverPoints(points, 0));
    }
}