using JetBrains.Annotations;
using source._2700._2739;

namespace test._2700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2739
{
    [TestMethod]
    public void Normal()
    {
        var solution = new Solution();
        var mainTank = 5;
        var additionTank = 10;
        var expected = 60;
        Assert.AreEqual(expected, solution.DistanceTraveled(mainTank, additionTank));
    }

    [TestMethod]
    public void Normal2()
    {
        var solution = new Solution();
        var mainTank = 1;
        var additionTank = 2;
        var expected = 10;
        Assert.AreEqual(expected, solution.DistanceTraveled(mainTank, additionTank));
    }

    [TestMethod]
    public void CostAdditionalTankAll()
    {
        var solution = new Solution();
        var mainTank = 9;
        var additionTank = 1;
        var expected = 100;
        Assert.AreEqual(expected, solution.DistanceTraveled(mainTank, additionTank));
    }
}