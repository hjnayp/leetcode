using JetBrains.Annotations;
using source._1200._1235;

namespace test._1200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1235
{
    [TestMethod]
    public void Normal()
    {
        var solution = new Solution();
        int[] startTime = { 1, 2, 3, 3 };
        int[] endTime = { 3, 4, 5, 6 };
        int[] profit = { 50, 10, 40, 70 };
        int result = solution.JobScheduling(startTime, endTime, profit);
        Assert.AreEqual(120, result);
    }

    [TestMethod]
    public void Normal2()
    {
        var solution = new Solution();
        int[] startTime = { 1, 2, 3, 4, 6 };
        int[] endTime = { 3, 5, 10, 6, 9 };
        int[] profit = { 20, 20, 100, 70, 60 };
        int result = solution.JobScheduling(startTime, endTime, profit);
        Assert.AreEqual(150, result);
    }

    [TestMethod]
    public void SameStartTime()
    {
        var solution = new Solution();
        int[] startTime = { 1, 1, 1 };
        int[] endTime = { 2, 3, 4 };
        int[] profit = { 5, 6, 4 };
        int result = solution.JobScheduling(startTime, endTime, profit);
        Assert.AreEqual(6, result);
    }
}