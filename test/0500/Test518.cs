using JetBrains.Annotations;
using source._0500._518;

namespace test._0500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test518
{
    private static void RunTest(int amount, int[] coins, int expected)
    {
        var solution = new Solution();
        Assert.AreEqual(expected, solution.Change(amount, coins));
    }

    [TestMethod]
    public void NormalCase()
    {
        RunTest(5, new[] { 1, 2, 5 }, 4);
        RunTest(3, new[] { 2 }, 0);
        RunTest(10, new[] { 10 }, 1);
    }
}