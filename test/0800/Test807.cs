using JetBrains.Annotations;
using source._0800._807;

namespace test._0800;

[TestClass, TestSubject(typeof(Solution))]
public class Test807
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int[][] grid = [[3, 0, 8, 4], [2, 4, 5, 7], [9, 2, 6, 3], [0, 3, 1, 0]];
        Assert.AreEqual(35, solution.MaxIncreaseKeepingSkyline(grid));

        grid = [[0, 0, 0], [0, 0, 0], [0, 0, 0]];
        Assert.AreEqual(0, solution.MaxIncreaseKeepingSkyline(grid));
    }
}