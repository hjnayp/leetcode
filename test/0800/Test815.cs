using JetBrains.Annotations;
using source._0800._815;

namespace test._0800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test815
{
    private Solution solution = new();
    private int[][] routes;
    private int source;
    private int target;
    private int expected;

    [TestMethod]
    [Timeout(1000)]
    public void TestSolution()
    {
        routes = [[1, 2, 7], [3, 6, 7]];
        source = 1;
        target = 6;
        expected = 2;
        Assert.AreEqual(expected, solution.NumBusesToDestination(routes, source, target));

        routes = [[7, 12], [4, 5, 15], [6], [15, 19], [9, 12, 13]];
        source = 15;
        target = 12;
        expected = -1;
        Assert.AreEqual(expected, solution.NumBusesToDestination(routes, source, target));

        routes = [[1, 2, 7], [3, 6, 7]];
        source = 8;
        target = 6;
        expected = -1;
        Assert.AreEqual(expected, solution.NumBusesToDestination(routes, source, target));

        routes = [[1, 2, 7], [3, 6, 7]];
        source = 7;
        target = 7;
        expected = 0;
        Assert.AreEqual(expected, solution.NumBusesToDestination(routes, source, target));
    }
}