using JetBrains.Annotations;
using source._0000._20;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test20
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        Assert.IsTrue(solution.IsValid("()"));
        Assert.IsTrue(solution.IsValid("([])"));
        Assert.IsTrue(solution.IsValid("()[]{}"));
        Assert.IsFalse(solution.IsValid("(]"));
        Assert.IsFalse(solution.IsValid("([)]"));
    }
}