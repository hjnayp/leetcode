using JetBrains.Annotations;
using source._3100._3143;

namespace test._3100;

[TestClass, TestSubject(typeof(Solution))]
public class Test3143
{
    private readonly Solution _solution = new();

    [TestMethod]
    public void NormalCase()
    {
        int[][] points = [[2, 2], [-1, -2], [-4, 4], [-3, 1], [3, -3]];
        string s = "abdca";
        Assert.AreEqual(2, _solution.MaxPointsInsideSquare(points, s));

        points = [[1, 1], [-2, -2], [-2, 2]];
        s = "abb";
        Assert.AreEqual(1, _solution.MaxPointsInsideSquare(points, s));

        points = [[16, 32], [27, 3], [23, -14], [-32, -16], [-3, 26], [-14, 33]];
        s = "aaabfc";
        Assert.AreEqual(2, _solution.MaxPointsInsideSquare(points, s));
    }

    [TestMethod, Timeout(1000)]
    public void BigCase()
    {
        int[][] points = [[-1000000000, -1000000000], [-1000000000, 1000000000]];
        string s = "zy";
        Assert.AreEqual(2, _solution.MaxPointsInsideSquare(points, s));
    }
}