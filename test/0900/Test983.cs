using JetBrains.Annotations;
using source._0900._983;

namespace test._0900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test983
{
    private Solution solution = new();

    [TestMethod]
    public void TestSolution()
    {
        int[] days = [1, 4, 6, 7, 8, 20],
            costs = [2, 7, 15];
        Assert.AreEqual(11, solution.MincostTickets(days, costs));

        days = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 31];
        costs = [2, 7, 15];
        Assert.AreEqual(17, solution.MincostTickets(days, costs));
    }
}