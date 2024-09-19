using JetBrains.Annotations;
using source._2400._2414;

namespace test._2400;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2414
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        string s = "abacaba";
        Assert.AreEqual(2, solution.LongestContinuousSubstring(s));

        s = "abcde";
        Assert.AreEqual(5, solution.LongestContinuousSubstring(s));
        
        s = "ace";
        Assert.AreEqual(1, solution.LongestContinuousSubstring(s));
    }
}