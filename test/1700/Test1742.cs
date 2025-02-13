using JetBrains.Annotations;
using source._1700._1742;

namespace test._1700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1742
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int low = 1;
        int high = 10;
        int expected = 2;
        Assert.AreEqual(expected, solution.CountBalls(low, high));

        high = 15;
        low = 5;
        expected = 2;
        Assert.AreEqual(expected, solution.CountBalls(low, high));

        low = 19;
        high = 28;
        expected = 2;
        Assert.AreEqual(expected, solution.CountBalls(low, high));

        low = 220;
        high = 548;
        expected = 32;
        Assert.AreEqual(expected, solution.CountBalls(low, high));
    }
}