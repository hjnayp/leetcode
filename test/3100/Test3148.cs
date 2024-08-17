using JetBrains.Annotations;
using source._3100._3148;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3148
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        int[][] grid = [[9, 5, 7, 3], [8, 9, 6, 1], [6, 7, 14, 3], [2, 5, 3, 1]];
        Assert.AreEqual(9, solution.MaxScore(grid));

        grid = [[4, 3, 2], [3, 2, 1]];
        Assert.AreEqual(-1, solution.MaxScore(grid));
    }
}