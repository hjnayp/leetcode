using JetBrains.Annotations;
using source._1800._1883;

namespace test._1800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1883
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var dist = new[] { 1, 3, 2 };
        var speed = 4;
        var hoursBefore = 2;
        Assert.AreEqual(1, solution.MinSkips(dist, speed, hoursBefore));
    }

    [TestMethod]
    public void NormalCase2()
    {
        var solution = new Solution();
        var dist = new[] { 7, 3, 5, 5 };
        var speed = 2;
        var hoursBefore = 10;
        Assert.AreEqual(2, solution.MinSkips(dist, speed, hoursBefore));
    }

    [TestMethod]
    public void UnReachAble()
    {
        var solution = new Solution();
        var dist = new[] { 7, 3, 5, 5 };
        var speed = 1;
        var hoursBefore = 10;
        Assert.AreEqual(-1, solution.MinSkips(dist, speed, hoursBefore));
    }
}