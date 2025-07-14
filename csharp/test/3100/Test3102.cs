using JetBrains.Annotations;
using source._3100._3102;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3102
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        int[][] points = [[3, 10], [5, 15], [10, 2], [4, 4]];
        Assert.AreEqual(12, solution.MinimumDistance(points));

        points = [[1, 1], [1, 1], [1, 1]];
        Assert.AreEqual(0, solution.MinimumDistance(points));

        points = [[5, 3], [4, 6], [2, 4], [1, 8], [3, 9], [1, 6]];
        Assert.AreEqual(6, solution.MinimumDistance(points));
    }
}