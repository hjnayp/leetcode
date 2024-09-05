using JetBrains.Annotations;
using source._3100._3174;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3174
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        Assert.AreEqual("a", solution.ClearDigits("aa1"));
    }

    [TestMethod]
    public void TestSolution_WhenDigitAndNonDigitCharCountSame_ShouldReturnEmptyString()
    {
        var solution = new Solution();
        Assert.AreEqual("", solution.ClearDigits("cb34"));
        Assert.AreEqual("", solution.ClearDigits("cb3a54"));
    }

    [TestMethod]
    public void TestSolution_WhenOnlyDigitChar_ShouldReturnEmptyString()
    {
        var solution = new Solution();
        Assert.AreEqual("", solution.ClearDigits("34"));
        Assert.AreEqual("", solution.ClearDigits("354"));
    }

    [TestMethod]
    public void TestSolution_WhenOnlyNonDigitChar_ShouldReturnSelf()
    {
        var solution = new Solution();
        Assert.AreEqual("fads", solution.ClearDigits("fads"));
        Assert.AreEqual("fsaatederew", solution.ClearDigits("fsaatederew"));
    }

    [TestMethod]
    public void TestSolution_WhenEmptyString_ShouldReturnSelf()
    {
        var solution = new Solution();
        Assert.AreEqual("", solution.ClearDigits(""));
    }
}