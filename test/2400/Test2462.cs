using JetBrains.Annotations;
using source._2400._2462;

namespace test._2400;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2462
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int[] costs = new[] { 17, 12, 10, 2, 7, 2, 11, 20, 8 };
        int k = 3;
        int candidates = 4;
        Assert.AreEqual(11, solution.TotalCost(costs, k, candidates));

        costs = new[] { 1, 2, 4, 1 };
        k = 3;
        candidates = 3;
        Assert.AreEqual(4, solution.TotalCost(costs, k, candidates));
    }
}