using JetBrains.Annotations;
using source._1500._1547;

namespace test._1500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1547
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int n = 7;
        int[] cuts = [1, 3, 4, 5];
        Assert.AreEqual(16, solution.MinCost(n, cuts));

        n = 9;
        cuts = [5, 6, 1, 4, 2];
        Assert.AreEqual(22, solution.MinCost(n, cuts));
    }
}