using JetBrains.Annotations;
using source._2900._2923;

namespace test._2900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2923
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var grid = new[]
        {
            new[] { 0, 1 },
            new[] { 0, 0 }
        };
        var expected = 0;
        Assert.AreEqual(expected, solution.FindChampion(grid));
    }

    [TestMethod]
    public void NormalCase2()
    {
        var solution = new Solution();
        var grid = new[]
        {
            new[] { 0, 0, 1 },
            new[] { 1, 0, 1 },
            new[] { 0, 0, 0 }
        };
        var expected = 1;
        Assert.AreEqual(expected, solution.FindChampion(grid));
    }
}