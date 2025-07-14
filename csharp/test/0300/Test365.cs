using JetBrains.Annotations;
using source._0300._365;

namespace test._0300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test365
{
    [TestMethod]
    [Timeout(1000)]
    public void normal_case()
    {
        Solution solution = new();
        Assert.AreEqual(true, solution.CanMeasureWater(3, 5, 4));
        Assert.AreEqual(false, solution.CanMeasureWater(2, 6, 5));
        Assert.AreEqual(true, solution.CanMeasureWater(1, 2, 3));
    }

    [TestMethod]
    [Timeout(1000)]
    public void normal_case_2()
    {
        Solution2 solution = new();
        Assert.AreEqual(true, solution.CanMeasureWater(3, 5, 4));
        Assert.AreEqual(false, solution.CanMeasureWater(2, 6, 5));
        Assert.AreEqual(true, solution.CanMeasureWater(1, 2, 3));
    }
}