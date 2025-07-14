using JetBrains.Annotations;
using source._0500._521;

namespace test._0500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test521
{
    private readonly Solution _solution = new();

    [TestMethod]
    public void normal_case()
    {
        Assert.AreEqual(3, _solution.FindLUSlength("aba", "cdc"));
        Assert.AreEqual(3, _solution.FindLUSlength("aaa", "bbb"));
    }

    [TestMethod]
    public void one_string_include_other_case()
    {
        Assert.AreEqual(5, _solution.FindLUSlength("aaaaa", "aaa"));
        Assert.AreEqual(6, _solution.FindLUSlength("aefeaf", "a"));
    }

    [TestMethod]
    public void two_string_same_case()
    {
        Assert.AreEqual(-1, _solution.FindLUSlength("aaa", "aaa"));
    }
}