using JetBrains.Annotations;
using source._2800._2846;

namespace test._2800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2846
{
    private readonly Solution _solution = new();

    [TestMethod]
    public void NormalCase()
    {
        var n = 8;

        var edges = new[]
        {
            new[] { 1, 2, 6 },
            new[] { 1, 3, 4 },
            new[] { 2, 4, 6 },
            new[] { 2, 5, 3 },
            new[] { 3, 6, 6 },
            new[] { 3, 0, 8 },
            new[] { 7, 0, 2 }
        };

        var queries = new[]
        {
            new[] { 4, 6 },
            new[] { 0, 4 },
            new[] { 6, 5 },
            new[] { 7, 4 }
        };

        var expected = new[] { 1, 2, 2, 3 };
        Assert.IsTrue(expected.SequenceEqual(_solution.MinOperationsQueries(n, edges, queries)));
    }
}