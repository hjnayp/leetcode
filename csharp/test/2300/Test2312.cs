using JetBrains.Annotations;
using source._2300._2312;

namespace test._2300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2312
{
    private int _m;
    private int _n;
    private int[][] _prices;
    private Solution _solution = new();

    [TestMethod]
    [Timeout(1000)]
    public void NormalCase()
    {
        _m = 3;
        _n = 5;
        _prices = new[]
        {
            new[] { 1, 4, 2 },
            new[] { 2, 2, 7 },
            new[] { 2, 1, 3 },
        };

        RunTest(19);
    }

    [TestMethod]
    [Timeout(2000)]
    public void TimeCostCase()
    {
        _m = 9;
        _n = 7;
        _prices = new[]
        {
            new[] { 4, 3, 2 },
            new[] { 5, 3, 16 },
            new[] { 4, 4, 18 },
            new[] { 8, 7, 6 },
        };
        RunTest(54);
    }

    private void RunTest(long expected)
    {
        long actual = _solution.SellingWood(_m, _n, _prices);
        Assert.AreEqual(expected, actual);
    }
}