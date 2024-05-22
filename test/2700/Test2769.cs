using JetBrains.Annotations;
using source._2700._2769;

namespace test._2700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2769
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        Assert.AreEqual(6, solution.TheMaximumAchievableX(4, 1));
        Assert.AreEqual(7, solution.TheMaximumAchievableX(3, 2));
    }
}