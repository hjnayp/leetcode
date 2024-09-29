using JetBrains.Annotations;
using source._2000._2073;

namespace test._2000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2073
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int[] tickets = [2, 3, 2];
        int k = 2;
        Assert.AreEqual(6, solution.TimeRequiredToBuy(tickets, k));

        tickets = [5, 1, 1, 1];
        k = 0;
        Assert.AreEqual(8, solution.TimeRequiredToBuy(tickets, k));

        tickets = [1, 1, 1, 1];
        k = 0;
        Assert.AreEqual(1, solution.TimeRequiredToBuy(tickets, k));
    }
}