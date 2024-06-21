using JetBrains.Annotations;
using source._0300._365;

namespace test._0300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test365
{
    private Solution2 _solution = new();

    [TestMethod]
    [Timeout(1000)]
    public void normal_case()
    {
        Assert.AreEqual(true, _solution.CanMeasureWater(3, 5, 4));
        Assert.AreEqual(false, _solution.CanMeasureWater(2, 6, 5));
        Assert.AreEqual(true, _solution.CanMeasureWater(1, 2, 3));
    }
}