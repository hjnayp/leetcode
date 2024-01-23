using source._0000._03;

namespace test._0000;

[TestClass]
public class Test03
{
    [TestMethod]
    [Timeout(1500)]
    public void NormalCase()
    {
        var solution = new Solution();
        var s = "abcabcbb";
        var expected = 3;
        var actual = solution.LengthOfLongestSubstring(s);
        Assert.AreEqual(expected, actual);

        s = "bbbbb";
        expected = 1;
        actual = solution.LengthOfLongestSubstring(s);
        Assert.AreEqual(expected, actual);

        s = "pwwkew";
        expected = 3;
        actual = solution.LengthOfLongestSubstring(s);
        Assert.AreEqual(expected, actual);

        s = "";
        expected = 0;
        actual = solution.LengthOfLongestSubstring(s);
        Assert.AreEqual(expected, actual);

        s = "aabaab!bb";
        expected = 3;
        actual = solution.LengthOfLongestSubstring(s);
        Assert.AreEqual(expected, actual);
    }
}