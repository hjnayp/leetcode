using JetBrains.Annotations;
using source._0700._741;

namespace test._0700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test741
{
    [TestMethod]
    public void can_pick_all_cherry()
    {
        var solution = new Solution();
        int[][] grid =
        {
            new[] { 0, 1, -1 },
            new[] { 1, 0, -1 },
            new[] { 1, 1, 1 }
        };
        Assert.AreEqual(5, solution.CherryPickup(grid));
    }

    [TestMethod]
    public void can_not_reach_left_down()
    {
        var solution = new Solution();
        int[][] grid =
        {
            new[] { 1, 1, -1 },
            new[] { 1, -1, 1 },
            new[] { -1, 1, 1 }
        };
        Assert.AreEqual(0, solution.CherryPickup(grid));
    }
}