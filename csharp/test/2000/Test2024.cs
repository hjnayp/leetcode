using JetBrains.Annotations;
using source._2000._2024;

namespace test._2000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2024
{
    [TestMethod]
    public void TestSolution_WhenCommon_ShouldEqualExpected()
    {
        var solution = new Solution();
        string answerKey = "TTFF";
        int k = 2;
        Assert.AreEqual(4, solution.MaxConsecutiveAnswers(answerKey, k));

        answerKey = "TFFT";
        k = 1;
        Assert.AreEqual(3, solution.MaxConsecutiveAnswers(answerKey, k));

        answerKey = "TTFTTFTT";
        k = 1;
        Assert.AreEqual(5, solution.MaxConsecutiveAnswers(answerKey, k));

        answerKey = "TTFTTTTTFT";
        k = 1;
        Assert.AreEqual(8, solution.MaxConsecutiveAnswers(answerKey, k));
    }

    [TestMethod]
    public void TestSolution_WhenAllAnswersAreFalse_ShouldOutputSameAsInputLength()
    {
        var solution = new Solution();
        string answerKey = "FFFF";
        int k = 2;
        Assert.AreEqual(answerKey.Length, solution.MaxConsecutiveAnswers(answerKey, k));

        k = 1;
        Assert.AreEqual(answerKey.Length, solution.MaxConsecutiveAnswers(answerKey, k));

        k = 10;
        Assert.AreEqual(answerKey.Length, solution.MaxConsecutiveAnswers(answerKey, k));
    }
}