using JetBrains.Annotations;
using source._2300._2398;

namespace test._2300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2398
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int[] chargeTimes = [3, 6, 1, 3, 4];
        int[] runningCosts = [2, 1, 3, 4, 5];
        int budget = 25;
        Assert.AreEqual(3, solution.MaximumRobots(chargeTimes, runningCosts, budget));

        chargeTimes = [11, 12, 19];
        runningCosts = [10, 8, 7];
        budget = 19;
        Assert.AreEqual(0, solution.MaximumRobots(chargeTimes, runningCosts, budget));

        chargeTimes = [32, 83, 96, 70, 98, 80, 30, 42, 63, 67, 49, 10, 80, 13, 69, 91, 73, 10];
        runningCosts = [49, 67, 92, 26, 18, 22, 38, 34, 36, 26, 32, 84, 39, 42, 88, 51, 8, 2];
        budget = 599;
        Assert.AreEqual(4, solution.MaximumRobots(chargeTimes, runningCosts, budget));

        chargeTimes = [19, 63, 21, 8, 5, 46, 56, 45, 54, 30, 92, 63, 31, 71, 87, 94, 67, 8, 19, 89, 79, 25];
        runningCosts = [91, 92, 39, 89, 62, 81, 33, 99, 28, 99, 86, 19, 5, 6, 19, 94, 65, 86, 17, 10, 8, 42];
        budget = 85;
        Assert.AreEqual(1, solution.MaximumRobots(chargeTimes, runningCosts, budget));
    }
}