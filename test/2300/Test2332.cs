using JetBrains.Annotations;
using source._2300._2332;

namespace test._2300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2332
{
    [TestMethod]
    public void TestNormal()
    {
        var solution = new Solution();
        int[] buses = [10, 20];
        int[] passengers = [2, 17, 18, 19];
        int capacity = 2;
        Assert.AreEqual(16, solution.LatestTimeCatchTheBus(buses, passengers, capacity));

        buses = [20, 30, 10];
        passengers = [4, 11, 13, 19, 21, 25, 26];
        capacity = 2;
        Assert.AreEqual(20, solution.LatestTimeCatchTheBus(buses, passengers, capacity));
    }
}