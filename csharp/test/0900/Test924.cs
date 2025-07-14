using JetBrains.Annotations;
using source._0900._924;

namespace test._0900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test924
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
    public void NormalCase2()
    {
        var solution = new Solution();
        var graph = new[]
        {
            new[] { 1, 0, 0 },
            new[] { 0, 1, 0 },
            new[] { 0, 0, 1 }
        };
        var initial = new[] { 0, 2 };
        var expected = 0;
        Assert.AreEqual(expected, solution.MinMalwareSpread(graph, initial));
    }

    [TestMethod]
    public void NormalCase3()
    {
        var solution = new Solution();
        var graph = new[]
        {
            new[] { 1, 1, 1 },
            new[] { 1, 1, 1 },
            new[] { 1, 1, 1 }
        };
        var initial = new[] { 1, 2 };
        var expected = 1;
        Assert.AreEqual(expected, solution.MinMalwareSpread(graph, initial));
    }

    [TestMethod]
    public void NormalCase4()
    {
        var solution = new Solution();
        int[][] graph =
        {
            new[] { 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
            new[] { 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0 },
            new[] { 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0 },
            new[] { 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0 },
            new[] { 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0 },
            new[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }
        };
        var initial = new[] { 7, 8, 6, 2, 3 };
        var expected = 2;
        Assert.AreEqual(expected, solution.MinMalwareSpread(graph, initial));
    }

    [TestMethod]
    public void NormalCase5()
    {
        var solution = new Solution();
        int[][] graph =
        {
            new[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
            new[] { 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
            new[] { 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 },
            new[] { 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 0 },
            new[] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
            new[] { 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 1 },
            new[] { 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
            new[] { 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
            new[] { 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 }
        };
        var initial = new[] { 1, 4 };
        var expected = 1;
        Assert.AreEqual(expected, solution.MinMalwareSpread(graph, initial));
    }
}