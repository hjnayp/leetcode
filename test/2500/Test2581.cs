using JetBrains.Annotations;
using source._2500._2581;
using source.InputParsers;

namespace test._2500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2581
{
    private Solution _solution = new();

    [TestMethod]
    public void normal_case()
    {
        int[][] edges;
        int[][] guesses;
        int k;

        edges = ArrayParser.ParseTwoDimensionalArray<int>("[[0,1],[1,2],[1,3],[4,2]]");
        guesses = ArrayParser.ParseTwoDimensionalArray<int>("[[1,3],[0,1],[1,0],[2,4]]");

        ISet<(int, int)> guessEdges = new HashSet<(int, int)>();
        foreach (int[] guess in guesses) guessEdges.Add((guess[0], guess[1]));
        k = 3;
        Assert.AreEqual(3, _solution.RootCount(edges, guesses, k));


        edges = ArrayParser.ParseTwoDimensionalArray<int>("[[0,1],[1,2],[2,3],[3,4]]");
        guesses = ArrayParser.ParseTwoDimensionalArray<int>("[[1,0],[3,4],[2,1],[3,2]]");
        k = 1;
        Assert.AreEqual(5, _solution.RootCount(edges, guesses, k));
    }
}