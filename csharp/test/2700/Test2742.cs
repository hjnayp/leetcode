using JetBrains.Annotations;
using source._2700._2742;
using source.InputParsers;

namespace test._2700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2742
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        int[] cost;
        int[] time;

        cost = ArrayParser.ParseOneDimensionalArray<int>("[1,2,3,2]");
        time = ArrayParser.ParseOneDimensionalArray<int>("[1,2,3,2]");
        Assert.AreEqual(3, solution.PaintWalls(cost, time));

        cost = ArrayParser.ParseOneDimensionalArray<int>("[2,3,4,2]");
        time = ArrayParser.ParseOneDimensionalArray<int>("[1,1,1,1]");
        Assert.AreEqual(4, solution.PaintWalls(cost, time));

        cost = ArrayParser.ParseOneDimensionalArray<int>("[1,8,9,13]");
        time = ArrayParser.ParseOneDimensionalArray<int>("[2,2,1,2]");
        Assert.AreEqual(9, solution.PaintWalls(cost, time));
    }
}