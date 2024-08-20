using JetBrains.Annotations;
using source._3100._3154;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3154
{

    [TestMethod]
    public void NormalCase()
    {
        Solution solution = new();
        Assert.AreEqual(2,solution.WaysToReachStair(0));
        Assert.AreEqual(4,solution.WaysToReachStair(1));
    }
}