using JetBrains.Annotations;
using source._0000._30;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test30
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        var s = "barfoothefoobarman";
        string[] words = ["foo", "bar"];
        int[] expected = [0, 9];
        CollectionAssert.AreEqual(expected, solution.FindSubstring(s, words).ToArray());

        s = "wordgoodgoodgoodbestword";
        words = ["word", "good", "best", "word"];
        expected = [];
        CollectionAssert.AreEqual(expected, solution.FindSubstring(s, words).ToArray());

        s = "barfoofoobarthefoobarman";
        words = ["bar", "foo", "the"];
        expected = [6, 9, 12];
        CollectionAssert.AreEqual(expected, solution.FindSubstring(s, words).ToArray());
    }

    [TestMethod]
    public void TestSolution_WhenStrLengthLessThanTheWordsTotalLength_ShouldReturnEmpty()
    {
        var solution = new Solution();
        var s = "aa";
        string[] words = ["foo", "bar"];
        int[] expected = [];
        CollectionAssert.AreEqual(expected, solution.FindSubstring(s, words).ToArray());
    }
    
    
}