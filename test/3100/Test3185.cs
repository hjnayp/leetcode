using JetBrains.Annotations;
using source._3100._3185;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3185
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();

        int[] hours = [];

        hours = [12, 12, 30, 24, 24];
        Assert.AreEqual(2, solution.CountCompleteDayPairs(hours));

        hours = [72, 48, 24, 3];
        Assert.AreEqual(3, solution.CountCompleteDayPairs(hours));
    }
}