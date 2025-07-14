using JetBrains.Annotations;
using source._0600._633;

namespace test._0600;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test633
{
    private Solution solution;

    [TestInitialize]
    public void Setup()
    {
        solution = new Solution();
    }

    [TestMethod]
    public void TestSolution_WhenSumIs0_ShoulJudgeTrue()
    {
        // zero is a square of zero
        Assert.IsTrue(solution.JudgeSquareSum(0));
    }

    [TestMethod]
    public void TestSolution_WhenSumIsSquareOfInteger_ShouldJudgeTrue()
    {
        Assert.IsTrue(solution.JudgeSquareSum(1));
        Assert.IsTrue(solution.JudgeSquareSum(4));
        Assert.IsTrue(solution.JudgeSquareSum(9));
        Assert.IsTrue(solution.JudgeSquareSum(16));
        Assert.IsTrue(solution.JudgeSquareSum(25));
    }

    [TestMethod]
    public void TestSolution_WhenSumIsTrueCase()
    {
        Assert.IsTrue(solution.JudgeSquareSum(5));
    }

    [TestMethod]
    public void TestSolution_WhenSumIsFalseCase()
    {
        Assert.IsFalse(solution.JudgeSquareSum(6));
        Assert.IsFalse(solution.JudgeSquareSum(7));
    }

    [TestMethod]
    [Timeout(1000)]
    public void TestSolution_WhenSumIsBigNumber()
    {
        Assert.IsTrue(solution.JudgeSquareSum(2147483600));
    }
}