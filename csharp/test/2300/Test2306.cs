using JetBrains.Annotations;
using source._2300._2306;

namespace test._2300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2306
{
    [TestMethod]
    public void TestSolution()
    {
        RunTestCase(6, ["coffee", "donuts", "time", "toffee"]);
        RunTestCase(0, ["lack", "back"]);
        RunTestCase(2, ["aaa", "baa", "caa", "bbb", "cbb", "dbb"]);
    }

    [Timeout(1000)]
    private static void RunTestCase(int expected, string[] ideas)
    {
        var solution = new Solution();
        Assert.AreEqual(expected, solution.DistinctNames(ideas));
    }
}