using JetBrains.Annotations;
using source._0000._09;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test09
{
    [TestMethod]
    public void normal_true_case()
    {
        Solution solution = new();
        Assert.IsTrue(solution.IsPalindrome(121));
        Assert.IsTrue(solution.IsPalindrome(11));
        Assert.IsTrue(solution.IsPalindrome(999999));
        Assert.IsTrue(solution.IsPalindrome(1));
    }

    [TestMethod]
    public void normal_false_case()
    {
        Solution solution = new();
        Assert.IsFalse(solution.IsPalindrome(56));
        Assert.IsFalse(solution.IsPalindrome(9841));
        Assert.IsFalse(solution.IsPalindrome(15645312));
        Assert.IsFalse(solution.IsPalindrome(20));
    }

    [TestMethod]
    public void negative_number_case()
    {
        Solution solution = new();
        Assert.IsFalse(solution.IsPalindrome(-1223));
        Assert.IsFalse(solution.IsPalindrome(-11));
    }
}