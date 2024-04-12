using JetBrains.Annotations;
using source._0000._05;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test05
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var s = "babad";
        var expected = "bab";
        Assert.AreEqual(expected, solution.LongestPalindrome(s));
    }

    [TestMethod]
    public void NormalCase2()
    {
        var solution = new Solution();
        var s = "cbbd";
        var expected = "bb";
        Assert.AreEqual(expected, solution.LongestPalindrome(s));
    }
}