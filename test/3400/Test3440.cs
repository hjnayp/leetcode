using JetBrains.Annotations;
using source._3400._3440;

namespace test._3400;

[TestClass, TestSubject(typeof(Solution))]
public class Test3440
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int[] startTime = [];
        int[] endTime = [];
        int eventTime = 0;
        int expected = 0;

        eventTime = 5;
        startTime = [1, 3];
        endTime = [2, 5];
        expected = 2;
        Assert.AreEqual(expected, solution.MaxFreeTime(eventTime, startTime, endTime));
    }
}