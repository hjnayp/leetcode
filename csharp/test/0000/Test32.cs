using JetBrains.Annotations;
using source._0000._32;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test32
{
    [TestMethod]
    public void TestSolution()
    {
        RunTest(2, "(()");
        RunTest(4, ")()())");
        RunTest(0, "");
        RunTest(2, "()(()");
        RunTest(4, "(()()");
    }

    [Timeout(1000)]
    private static void RunTest(int expected, string s)
    {
        var solution = new Solution();
        Assert.AreEqual(expected, solution.LongestValidParentheses(s));
    }
}