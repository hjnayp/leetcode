using JetBrains.Annotations;
using source._0500._503;
using source.InputParsers;

namespace test._0500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test503
{
    private Solution _solution = new();

    [Timeout(1000)]
    [TestMethod]
    public void normal_case()
    {
        int[] nums;
        int[] res;

        nums = ArrayParser.ParseOneDimensionalArray<int>("[1,2,1]");
        res = ArrayParser.ParseOneDimensionalArray<int>("[2,-1,2]");
        CollectionAssert.AreEqual(res, _solution.NextGreaterElements(nums));

        nums = ArrayParser.ParseOneDimensionalArray<int>("[1,2,3,4,3]");
        res = ArrayParser.ParseOneDimensionalArray<int>("[2,3,4,-1,4]");
        CollectionAssert.AreEqual(res, _solution.NextGreaterElements(nums));
    }

    [Timeout(1000)]
    [TestMethod]
    public void edge_cases()
    {
        int[] nums;
        int[] res;

        nums = ArrayParser.ParseOneDimensionalArray<int>("[1]");
        res = ArrayParser.ParseOneDimensionalArray<int>("[-1]");
        CollectionAssert.AreEqual(res, _solution.NextGreaterElements(nums));
        nums = ArrayParser.ParseOneDimensionalArray<int>("[[1,1,1,1,1]]");
        res = ArrayParser.ParseOneDimensionalArray<int>("[-1,-1,-1,-1,-1]");
        CollectionAssert.AreEqual(res, _solution.NextGreaterElements(nums));
    }
}