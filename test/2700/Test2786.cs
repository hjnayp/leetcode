using JetBrains.Annotations;
using source._2700._2786;
using source.InputParsers;

namespace test._2700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2786
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        int[] nums = ArrayParser.ParseOneDimensionalArray<int>("[2,3,6,1,9,2]");
        Assert.AreEqual(13, solution.MaxScore(nums, 5));

        nums = ArrayParser.ParseOneDimensionalArray<int>("[2,4,6,8]");
        Assert.AreEqual(20, solution.MaxScore(nums, 3));

        nums = ArrayParser.ParseOneDimensionalArray<int>("[8,50,65,85,8,73,55,50,29,95,5,68,52,79]");
        Assert.AreEqual(470, solution.MaxScore(nums, 74));
    }
}