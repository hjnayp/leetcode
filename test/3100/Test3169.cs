using JetBrains.Annotations;
using source._3100._3169;

namespace test._3100;

[TestClass, TestSubject(typeof(Solution))]
public class Test3169
{
    [TestMethod, Timeout(1000)]
    public void TestSolution()
    {
        Solution solution = new();
        int days = 1000000000;
        int[][] meetings = [[1, 1000000000]];
        int expected = 0;
        Assert.AreEqual(expected, solution.CountDays(days, meetings));
    }

    [TestMethod, Timeout(1000)]
    public void TestSolution_MultipleMeetings()
    {
        Solution solution = new();
        int days = 10;
        int[][] meetings = [[5, 7], [1, 3], [9, 10]];
        int expected = 2;
        Assert.AreEqual(expected, solution.CountDays(days, meetings));
    }

    [TestMethod, Timeout(1000)]
    public void TestSolution_OverlappingMeetings()
    {
        Solution solution = new();
        int days = 5;
        int[][] meetings = [[2, 4], [1, 3]];
        int expected = 1;
        Assert.AreEqual(expected, solution.CountDays(days, meetings));
    }

    [TestMethod, Timeout(1000)]
    public void TestSolution_SingleMeeting()
    {
        Solution solution = new();
        int days = 6;
        int[][] meetings = [[1, 6]];
        int expected = 0;
        Assert.AreEqual(expected, solution.CountDays(days, meetings));
    }
}