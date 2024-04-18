using JetBrains.Annotations;
using source._0900._928;

namespace test._0900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test928
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var graph = new[]
        {
            new[] { 1, 1, 0 },
            new[] { 1, 1, 0 },
            new[] { 0, 0, 1 }
        };
        var initial = new[] { 0, 1 };
        var expected = 0;
        Assert.AreEqual(expected, solution.MinMalwareSpread(graph, initial));
    }

    [TestMethod]
    public void NormalCase1()
    {
        var solution = new Solution();
        var graph = new[]
        {
            new[] { 1, 1, 0 },
            new[] { 1, 1, 1 },
            new[] { 0, 1, 1 }
        };
        var initial = new[] { 0, 1 };
        var expected = 1;
        Assert.AreEqual(expected, solution.MinMalwareSpread(graph, initial));
    }

    [TestMethod]
    public void NormalCase2()
    {
        var solution = new Solution();
        int[][] graph =
        {
            new[] { 1, 0, 0, 0, 0, 0, 0, 0, 1 },
            new[] { 0, 1, 0, 1, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 1, 1, 0, 1, 0, 0, 0 },
            new[] { 0, 1, 1, 1, 1, 0, 1, 0, 0 },
            new[] { 0, 0, 0, 1, 1, 1, 0, 0, 0 },
            new[] { 0, 0, 1, 0, 1, 1, 0, 0, 0 },
            new[] { 0, 0, 0, 1, 0, 0, 1, 1, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 1, 1, 1 },
            new[] { 1, 0, 0, 0, 0, 0, 0, 1, 1 }
        };
        var initial = new[] { 3, 7 };
        var expected = 3;
        Assert.AreEqual(expected, solution.MinMalwareSpread(graph, initial));
    }

    [TestMethod]
    public void NormalCase3()
    {
        var solution = new Solution();
        int[][] graph =
        {
            new[] { 1, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 1, 0, 0, 0, 0, 0, 0, 1 },
            new[] { 0, 0, 1, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 1, 0, 0, 0, 0, 1 },
            new[] { 0, 0, 0, 0, 1, 0, 1, 1, 1 },
            new[] { 0, 0, 0, 0, 0, 1, 0, 0, 1 },
            new[] { 0, 0, 0, 0, 1, 0, 1, 1, 0 },
            new[] { 0, 0, 0, 0, 1, 0, 1, 1, 0 },
            new[] { 0, 1, 0, 1, 1, 1, 0, 0, 1 }
        };
        var initial = new[] { 8, 4, 2, 0 };
        var expected = 8;
        Assert.AreEqual(expected, solution.MinMalwareSpread(graph, initial));
    }
}