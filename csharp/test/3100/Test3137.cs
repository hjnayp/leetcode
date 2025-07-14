using JetBrains.Annotations;
using source._3100._3137;

namespace test._3100;

[TestClass, TestSubject(typeof(Solution))]
public class Test3137
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        Assert.AreEqual(1, solution.MinimumOperationsToMakeKPeriodic("leetcodeleet", 4));
        Assert.AreEqual(3, solution.MinimumOperationsToMakeKPeriodic("leetcoleet", 2));
    }
}