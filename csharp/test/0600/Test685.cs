using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using source._0600._685;

namespace test._0600;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test685
{
    private Solution _solution = new();

    [TestMethod]
    public void TestSolution()
    {
        int[][] edges = [[1, 2], [1, 3], [2, 3]];
        int[] output = [2, 3];
        RunTest(edges, output);

        edges = [[1, 2], [2, 3], [3, 4], [4, 1], [1, 5]];
        output = [4, 1];
        RunTest(edges, output);

        edges = [[2, 1], [3, 1], [4, 2], [1, 4]];
        output = [2, 1];
        RunTest(edges, output);
    }

    [ExcludeFromCodeCoverage]
    private void RunTest(int[][] edges, int[] output)
    {
        int[] result = _solution.FindRedundantDirectedConnection(edges);
        CollectionAssert.AreEqual(result, output);
    }
}