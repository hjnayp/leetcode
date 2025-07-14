using JetBrains.Annotations;
using source._2900._2929;

namespace test._2900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2929
{
    [TestMethod]
    public void TestMethod()
    {
        var solution = new Solution();
        int n, limit;
        long expected, actual;

        n = 5;
        limit = 2;
        expected = 3;
        actual = solution.DistributeCandies(n, limit);
        Assert.AreEqual(expected, actual);

        n = 3;
        limit = 3;
        expected = 10;
        actual = solution.DistributeCandies(n, limit);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    [Timeout(500)]
    public void TestMethod_WithTimeLimit()
    {
        var solution = new Solution();
        int n, limit;
        long expected, actual;

        n = 10001;
        limit = 20013;

        expected = 50025003;
        actual = solution.DistributeCandies(n, limit);
        Assert.AreEqual(expected, actual);
    }
}