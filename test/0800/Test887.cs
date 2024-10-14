using JetBrains.Annotations;
using source._0800._887;

namespace test._0800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test887
{
    [TestMethod, Timeout(3000)]
    public void TestSolution()
    {
        var solution = new Solution();
        Assert.AreEqual(2, solution.SuperEggDrop(1, 2));
        Assert.AreEqual(3, solution.SuperEggDrop(2, 6));
        Assert.AreEqual(4, solution.SuperEggDrop(3, 14));
        Assert.AreEqual(2, solution.SuperEggDrop(2, 2));
        Assert.AreEqual(3, solution.SuperEggDrop(2, 4));
        Assert.AreEqual(5, solution.SuperEggDrop(3, 25));
    }
}