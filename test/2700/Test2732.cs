using JetBrains.Annotations;
using source._2700._2732;
using source.InputParsers;

namespace test._2700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2732
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        int[][] grid;
        IList<int> res;


        grid = ArrayParser.ParseTwoDimensionalArray<int>("[[0,1,1,0],[0,0,0,1],[1,1,1,1]]");
        res = ArrayParser.ParseOneDimensionalArray<int>("[0,1]");
        CollectionAssert.AreEqual(res.ToArray(), solution.GoodSubsetofBinaryMatrix(grid).ToArray());

        grid = ArrayParser.ParseTwoDimensionalArray<int>("[[0]]");
        res = ArrayParser.ParseOneDimensionalArray<int>("[0]");
        CollectionAssert.AreEqual(res.ToArray(), solution.GoodSubsetofBinaryMatrix(grid).ToArray());

        grid = ArrayParser.ParseTwoDimensionalArray<int>("[[1,1,1],[1,1,1]]");
        res = ArrayParser.ParseOneDimensionalArray<int>("[]");
        CollectionAssert.AreEqual(res.ToArray(), solution.GoodSubsetofBinaryMatrix(grid).ToArray());
    }
}