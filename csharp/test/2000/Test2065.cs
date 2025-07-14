using JetBrains.Annotations;
using source._2000._2065;
using source.InputParsers;

namespace test._2000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2065
{
    private readonly Solution _solution = new();
    private int[] _values = [];
    private int[][] _edges = [];
    private int _maxTime;

    [TestMethod]
    public void normal_case1()
    {
        _values = ArrayParser.ParseOneDimensionalArray<int>("[0,32,10,43]");
        _edges = ArrayParser.ParseTwoDimensionalArray<int>("[[0,1,10],[1,2,15],[0,3,10]]");
        _maxTime = 49;
        Assert.AreEqual(75, _solution.MaximalPathQuality(_values, _edges, _maxTime));
    }

    [TestMethod]
    public void normal_case2()
    {
        _values = ArrayParser.ParseOneDimensionalArray<int>("[5,10,15,20]");
        _edges = ArrayParser.ParseTwoDimensionalArray<int>("[[0,1,10],[1,2,10],[0,3,10]]");
        _maxTime = 30;
        Assert.AreEqual(25, _solution.MaximalPathQuality(_values, _edges, _maxTime));
    }

    [TestMethod]
    public void normal_case3()
    {
        _values = ArrayParser.ParseOneDimensionalArray<int>("[1,2,3,4]");
        _edges = ArrayParser.ParseTwoDimensionalArray<int>("[[0,1,10],[1,2,11],[2,3,12],[1,3,13]]");
        _maxTime = 50;
        Assert.AreEqual(7, _solution.MaximalPathQuality(_values, _edges, _maxTime));
    }

    [TestMethod]
    public void not_connected_and_no_valid_path_case()
    {
        _values = ArrayParser.ParseOneDimensionalArray<int>("[0,1,2]");
        _edges = ArrayParser.ParseTwoDimensionalArray<int>("[[1,2,10]]");
        _maxTime = 10;
        Assert.AreEqual(0, _solution.MaximalPathQuality(_values, _edges, _maxTime));
    }
}