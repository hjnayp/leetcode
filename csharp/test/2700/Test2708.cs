using JetBrains.Annotations;
using source._2700._2708;

namespace test._2700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2708
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();
        int[] nums = [3, -1, -5, 2, 5, -9];
        Assert.AreEqual(1350, solution.MaxStrength(nums));

        nums = [-4, -5, -4];
        Assert.AreEqual(20, solution.MaxStrength(nums));
    }

    [TestMethod]
    public void TestSolution_WhenOnlyOneNegativeNumber_ShouldReturnNegativeNumber()
    {
        Solution solution = new();
        int[] nums = [-1];
        Assert.AreEqual(-1, solution.MaxStrength(nums));
    }

    [TestMethod]
    public void TestSolution_WhenOnlyOneZeroAndNegativeValue_ShouldReturnZero()
    {
        Solution solution = new();
        int[] nums = [-1, 0];
        Assert.AreEqual(0, solution.MaxStrength(nums));
    }

    [TestMethod]
    public void TestSolution_WhenOnlyOneNegativeValue_ShouldReturnTheAggregationOfPositiveValue()
    {
        Solution solution = new();
        int[] nums = [-1, 0, 1, 2];
        Assert.AreEqual(2, solution.MaxStrength(nums));
    }

    [TestMethod]
    public void TestSolution_WhenCountOfNegativeNumberIsEven_ShouldReturnTheAggregationOfAllNonZeroNumber()
    {
        Solution solution = new();
        int[] nums = [-1, -2, 0, 1, 2];
        Assert.AreEqual(4, solution.MaxStrength(nums));
    }

    [TestMethod]
    public void TestSolution_WhenOnlyOneZero_ShouldReturnZero()
    {
        Solution solution = new();
        int[] nums = [0];
        Assert.AreEqual(0, solution.MaxStrength(nums));
    }
}