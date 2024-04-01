using source._0300._304;

namespace test._0300;

[TestClass]
public class Test304
{
    [TestMethod]
    [Timeout(1500)]
    public void NormalCase()
    {
        var matrix = new[]
        {
            new[] { 3, 0, 1, 4, 2 },
            new[] { 5, 6, 3, 2, 1 },
            new[] { 1, 2, 0, 1, 5 },
            new[] { 4, 1, 0, 1, 7 },
            new[] { 1, 0, 3, 0, 5 },
        };
        var solution = new NumMatrix(matrix);

        var expected = 8;
        Assert.AreEqual(expected, solution.SumRegion(2, 1, 4, 3));

        expected = 11;
        Assert.AreEqual(expected, solution.SumRegion(1, 1, 2, 2));

        expected = 12;
        Assert.AreEqual(expected, solution.SumRegion(1, 2, 2, 4));
    }
}