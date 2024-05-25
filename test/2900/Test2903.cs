using JetBrains.Annotations;
using source._2900;

namespace test._2900;

[TestClass, TestSubject(typeof(Solution))]
public class Test2903
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int[] nums = { 5, 1, 4, 1 };
        int indexDifference = 2;
        int valueDifference = 4;

        int[] result = { 0, 3 };
        CollectionAssert.AreEquivalent(result, solution.FindIndices(nums, indexDifference, valueDifference));
    }

    [TestMethod]
    public void zero_index_difference_case()
    {
        var solution = new Solution();
        int[] nums = { 2, 1 };
        int indexDifference = 0;
        int valueDifference = 0;

        int[] result = { 0, 0 };
        CollectionAssert.AreEquivalent(result, solution.FindIndices(nums, indexDifference, valueDifference));
    }
}