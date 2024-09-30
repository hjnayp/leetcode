using JetBrains.Annotations;
using source._0000._38;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test38
{
    [TestMethod]
    public void TestSolution()
    {
        var soltuion = new Solution();
        Assert.AreEqual("1", soltuion.CountAndSay(1));
        Assert.AreEqual("11", soltuion.CountAndSay(2));
        Assert.AreEqual("21", soltuion.CountAndSay(3));
        Assert.AreEqual("1211", soltuion.CountAndSay(4));
    }
}