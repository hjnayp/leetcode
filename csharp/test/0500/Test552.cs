using JetBrains.Annotations;
using source._0500._552;

namespace test._0500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test552
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        Assert.AreEqual(8, solution.CheckRecord(2));
        Assert.AreEqual(3, solution.CheckRecord(1));
        Assert.AreEqual(183236316, solution.CheckRecord(10101));
    }
}