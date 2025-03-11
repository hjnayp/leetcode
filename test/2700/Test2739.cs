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
        int mainTank = 5;
        int additionTank = 10;
        int expected = 60;
        Assert.AreEqual(expected, solution.DistanceTraveled(mainTank, additionTank));
    }

    [TestMethod]
    public void Normal2()
    {
        var solution = new Solution();
        int mainTank = 1;
        int additionTank = 2;
        int expected = 10;
        Assert.AreEqual(expected, solution.DistanceTraveled(mainTank, additionTank));
    }

    [TestMethod]
    public void CostAdditionalTankAll()
    {
        var solution = new Solution();
        int mainTank = 9;
        int additionTank = 1;
        int expected = 100;
        Assert.AreEqual(expected, solution.DistanceTraveled(mainTank, additionTank));
    }
}