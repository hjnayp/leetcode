using JetBrains.Annotations;
using source._3100._3142;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3142
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        int[][] grid = [[1, 0, 2], [1, 0, 2]];
        Assert.IsTrue(solution.SatisfiesConditions(grid));

        grid = [[1, 1, 1], [0, 0, 0]];
        Assert.IsFalse(solution.SatisfiesConditions(grid));

        grid = [[1, 1, 1], [1, 0, 0], [1, 0, 0]];
        Assert.IsFalse(solution.SatisfiesConditions(grid));

        grid = [[1], [2], [3]];
        Assert.IsFalse(solution.SatisfiesConditions(grid));
    }
}