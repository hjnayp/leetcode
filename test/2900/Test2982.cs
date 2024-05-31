using JetBrains.Annotations;
using source._2900._2982;

namespace test._2900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2982
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        Assert.AreEqual(2, solution.MaximumLength("aaaa"));
        Assert.AreEqual(1, solution.MaximumLength("abcaba"));
    }

    [TestMethod]
    public void special_case_01()
    {
        var solution = new Solution();
        Assert.AreEqual(1, solution.MaximumLength("eccdnmcnkl"));
        Assert.AreEqual(4, solution.MaximumLength("lkwwdddddnnnnnynnnnl"));
    }

    [TestMethod]
    public void no_special_substring_occur()
    {
        var solution = new Solution();
        Assert.AreEqual(-1, solution.MaximumLength("abcdef"));
        Assert.AreEqual(-1, solution.MaximumLength("acc"));
    }
}