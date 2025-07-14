using JetBrains.Annotations;
using source._2800._2848;

namespace test._2800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2848
{
    private Solution _solution;

    [TestInitialize]
    public void Initialize()
    {
        _solution = new Solution();
    }

    [TestMethod]
    public void TestSolution()
    {
        List<IList<int>> points = [[1, 1]];
        int result = _solution.NumberOfPoints(points);
        Assert.AreEqual(1, result);

        points = [[3, 6], [1, 5], [4, 7]];
        result = _solution.NumberOfPoints(points);
        Assert.AreEqual(7, result);

        points = [[1, 3], [5, 8]];
        result = _solution.NumberOfPoints(points);
        Assert.AreEqual(7, result);

        points = [[4, 4], [9, 10], [9, 10], [3, 8]];
        result = _solution.NumberOfPoints(points);
        Assert.AreEqual(8, result);
    }
}