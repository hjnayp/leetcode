using JetBrains.Annotations;
using source._0800._826;

namespace test._0800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test826
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        int[] difficulty = [2, 4, 6, 8, 10];
        int[] profit = [10, 20, 30, 40, 50];
        int[] worker = [4, 5, 6, 7];
        Assert.AreEqual(100, solution.MaxProfitAssignment(difficulty, profit, worker));
    }

    [TestMethod]
    public void all_profit_difficulty_work_same()
    {
        Solution solution = new();
        int[] difficulty = [10, 10, 10, 10];
        int[] profit = [10, 10, 10, 10];
        int[] worker = [10, 10, 10, 10];
        Assert.AreEqual(40, solution.MaxProfitAssignment(difficulty, profit, worker));
    }

    [TestMethod]
    public void gain_no_profit_case()
    {
        Solution solution = new();
        int[] difficulty = [85, 47, 57];
        int[] profit = [24, 66, 99];
        int[] worker = [40, 25, 25];
        Assert.AreEqual(0, solution.MaxProfitAssignment(difficulty, profit, worker));
    }
}