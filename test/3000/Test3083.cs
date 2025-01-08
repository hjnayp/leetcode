using JetBrains.Annotations;
using source._3000._3083;

namespace test._3000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3083
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        string input = "leafbcaef";
        Assert.IsTrue(solution.IsSubstringPresent(input));

        input = "abcba";
        Assert.IsTrue(solution.IsSubstringPresent(input));

        input = "cabd";
        Assert.IsFalse(solution.IsSubstringPresent(input));

        input = "leafbcaef";
        Assert.IsTrue(solution.IsSubstringPresent(input));
    }
}