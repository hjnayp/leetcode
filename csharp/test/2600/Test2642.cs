using JetBrains.Annotations;
using source._2600._2642;
using Floyd = source._2600._2642.Floyd;
using Dijkstra = source._2600._2642.Dijkstra;

namespace test._2600;

[TestClass]
[TestSubject(typeof(Floyd.Graph))]
public class Test2642Floyd
{
    [Timeout(1000)]
    [TestMethod]
    public void Test()
    {
        TestRunner.NormalCase<Floyd.Graph>();
    }
}

[TestClass]
[TestSubject(typeof(Dijkstra.Graph))]
public class Test2642Dijkstra
{
    [TestMethod]
    public void Test()
    {
        TestRunner.NormalCase<Dijkstra.Graph>();
    }
}

public static class TestRunner
{
    public static void NormalCase<T>() where T : IGraph
    {
        T solution = (T)Activator.CreateInstance(typeof(T), 4, new[]
        {
            new[] { 0, 2, 5 },
            new[] { 0, 1, 2 },
            new[] { 1, 2, 1 },
            new[] { 3, 0, 3 }
        })!;
        Assert.AreEqual(6, solution.ShortestPath(3, 2));
        Assert.AreEqual(-1, solution.ShortestPath(0, 3));
        solution.AddEdge(new[] { 1, 3, 4 });
        Assert.AreEqual(6, solution.ShortestPath(0, 3));
    }
}