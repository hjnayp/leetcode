using JetBrains.Annotations;
using source._2900._2917;
using source.InputParsers;

namespace test._2900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2917
{
    private Solution _solution = new();
    private int[] _nums;

    [TestMethod]
    public void normal_case()
    {
        _nums = ArrayParser.ParseOneDimensionalArray<int>("[7,12,9,8,9,15]");
        Assert.AreEqual(9, _solution.FindKOr(_nums, 4));
        _nums = ArrayParser.ParseOneDimensionalArray<int>("[2,12,1,11,4,5]");
        Assert.AreEqual(0, _solution.FindKOr(_nums, 6));
        _nums = ArrayParser.ParseOneDimensionalArray<int>("[10,8,5,9,11,6,8]");
        Assert.AreEqual(15, _solution.FindKOr(_nums, 1));
    }
}