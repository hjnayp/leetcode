using JetBrains.Annotations;
using source._3000._3072;
using source.InputParsers;

namespace test._3000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3072
{
    [TestMethod]
    public void normal_case()
    {
        Run("[5,14,3,1,2]", "[5,3,1,2,14]");
        Run("[2,1,3,3]", "[2,3,1,3]");
        Run("[3,3,3,3]", "[3,3,3,3]");
        Run("[2,38,2]", "[2,38,2]");
        Run("[1,30,73,15]", "[1,73,30,15");
    }

    private void Run(string input, string result)
    {
        var solution = new Solution();
        int[] nums = ArrayParser.ParseOneDimensionalArray<int>(input);
        int[] expected = ArrayParser.ParseOneDimensionalArray<int>(result);
        CollectionAssert.AreEqual(expected, solution.ResultArray(nums));
    }
}