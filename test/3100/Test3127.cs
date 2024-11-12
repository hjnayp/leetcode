using JetBrains.Annotations;
using source._3100._3127;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3127
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        char[][] grid = [['B', 'W', 'B'], ['B', 'W', 'W'], ['B', 'W', 'B']];
        Assert.IsTrue(solution.CanMakeSquare(grid));

        grid = [['B', 'W', 'B'], ['W', 'B', 'W'], ['B', 'W', 'B']];
        Assert.IsFalse(solution.CanMakeSquare(grid));

        grid = [['B', 'W', 'B'], ['B', 'W', 'W'], ['B', 'W', 'W']];
        Assert.IsTrue(solution.CanMakeSquare(grid));

        grid =
        [
            ['B', 'B', 'B'],
            ['W', 'W', 'W'],
            ['B', 'W', 'W'],
        ];
        Assert.IsTrue(solution.CanMakeSquare(grid));
    }
}