using JetBrains.Annotations;
using source._0000._10;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test10
{
    private readonly Solution _solution = new();

    [TestMethod]
    public void normal_case()
    {
        Assert.IsFalse(_solution.IsMatch("aa", "a"));
    }

    [TestMethod]
    public void contain_special_char_case()
    {
        Assert.IsTrue(_solution.IsMatch("aa", "a*"));
        Assert.IsTrue(_solution.IsMatch("afdsfrfasd", ".*"));
        Assert.IsFalse(_solution.IsMatch("ab", ".*c"));
        Assert.IsTrue(_solution.IsMatch("abc", ".*c"));
    }

    [TestMethod]
    public void any_char_zero_case()
    {
        Assert.IsTrue(_solution.IsMatch("aab", "c*a*b"));
    }
}