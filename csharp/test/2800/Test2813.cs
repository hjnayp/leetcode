using JetBrains.Annotations;
using source._2800._2813;
using source.InputParsers;

namespace test._2800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2813
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();

        int[][] items = ArrayParser.ParseTwoDimensionalArray<int>("[[3,2],[5,1],[10,1]]");
        Assert.AreEqual(17, solution.FindMaximumElegance(items, 2));

        items = ArrayParser.ParseTwoDimensionalArray<int>("[[3,1],[3,1],[2,2],[5,3]]");
        Assert.AreEqual(19, solution.FindMaximumElegance(items, 3));

        items = ArrayParser.ParseTwoDimensionalArray<int>("[[1,1],[2,1],[3,1]]");
        Assert.AreEqual(7, solution.FindMaximumElegance(items, 3));

        items = ArrayParser.ParseTwoDimensionalArray<int>("[[2,2],[8,1],[5,1]]");
        Assert.AreEqual(14, solution.FindMaximumElegance(items, 2));

        items = ArrayParser.ParseTwoDimensionalArray<int>("[[2,2],[7,2],[9,1],[1,1]]");
        Assert.AreEqual(22, solution.FindMaximumElegance(items, 3));

        items = ArrayParser.ParseTwoDimensionalArray<int>("[[2,2],[7,2],[9,1],[1,1]]");
        Assert.AreEqual(22, solution.FindMaximumElegance(items, 3));
    }

    [TestMethod]
    public void not_passed_test()
    {
        Solution solution = new();
        int[][] items = ArrayParser.ParseTwoDimensionalArray<int>(
            "[[10,1],[10,1],[10,1],[10,1],[10,1],[10,1],[10,1],[10,1],[10,1],[10,1],[3,2],[3,3],[3,4],[3,5],[3,6],[3,7],[3,8],[3,9],[3,10],[3,11]]");
        Assert.AreEqual(137, solution.FindMaximumElegance(items, 10));
    }
}