using JetBrains.Annotations;
using source._3000._3067;
using source.InputParsers;

namespace test._3000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3067
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        int[][] edges = ArrayParser.ParseTwoDimensionalArray<int>("[[0,1,1],[1,2,5],[2,3,13],[3,4,9],[4,5,2]]");
        int signalSpeed = 1;
        CollectionAssert.AreEquivalent(ArrayParser.ParseOneDimensionalArray<int>("[0,4,6,6,4,0]"),
            solution.CountPairsOfConnectableServers(edges, signalSpeed));

        edges = ArrayParser.ParseTwoDimensionalArray<int>("[[0,6,3],[6,5,3],[0,3,1],[3,2,7],[3,1,6],[3,4,2]]");
        signalSpeed = 3;
        CollectionAssert.AreEquivalent(ArrayParser.ParseOneDimensionalArray<int>("[2,0,0,0,0,0,2]"),
            solution.CountPairsOfConnectableServers(edges, signalSpeed));
    }
}