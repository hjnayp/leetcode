using source._0600._670;

namespace test._0600;

[TestClass]
public class Test670
{
    private Solution _solution = new();

    [TestMethod]
    public void WrongCase()
    {
        var num = 10909091;
        var expected = 90909011;
        Assert.AreEqual(expected, _solution.MaximumSwap(num));
    }

    [TestMethod]
    public void NormalCase()
    {
        var num = 2736;
        var expected = 7236;
        Assert.AreEqual(expected, _solution.MaximumSwap(num));

        num = 98368;
        expected = 98863;
        Assert.AreEqual(expected, _solution.MaximumSwap(num));

        num = 1993;
        expected = 9913;
        Assert.AreEqual(expected, _solution.MaximumSwap(num));

        num = 22341345;
        expected = 52341342;
        Assert.AreEqual(expected, _solution.MaximumSwap(num));
    }

    [TestMethod]
    public void OneDigitCase()
    {
        var num = 1;
        var expected = 1;
        Assert.AreEqual(expected, _solution.MaximumSwap(num));
    }

    [TestMethod]
    public void ZeroEndCase()
    {
        var num = 90;
        var expected = 90;
        Assert.AreEqual(expected, _solution.MaximumSwap(num));
    }
}