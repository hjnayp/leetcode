using JetBrains.Annotations;
using source._0000._44;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test44
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();

        string s = "aa";
        string p = "a";
        Assert.IsFalse(solution.IsMatch(s, p));

        s = "aa";
        p = "*";
        Assert.IsTrue(solution.IsMatch(s, p));

        s = "cb";
        p = "?a";
        Assert.IsFalse(solution.IsMatch(s, p));
    }
}