using source._2600._2646;

namespace test._2600;

[TestClass]
public class Test2646
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var n = 4;
        var edges = new[]
        {
            new[] { 0, 1 },
            new[] { 1, 2 },
            new[] { 1, 3 },
        };
        var price = new[] { 2, 2, 10, 6 };
        var trips = new[]
        {
            new[] { 0, 3 },
            new[] { 2, 1 },
            new[] { 2, 3 },
        };
        var expected = 23;
        var actual = solution.MinimumTotalPrice(n, edges, price, trips);
        Assert.AreEqual(expected, actual);

        n = 2;
        edges = new[]
        {
            new[] { 0, 1 },
        };
        price = new[] { 2, 2 };
        trips = new[]
        {
            new[] { 0, 0 },
        };
        expected = 1;
        actual = solution.MinimumTotalPrice(n, edges, price, trips);
        Assert.AreEqual(expected, actual);
    }
}