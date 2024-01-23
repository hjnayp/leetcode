using source._2000._2048;

namespace test._2000;

[TestClass]
public class Test2048
{
    [TestMethod]
    [Timeout(1000)]
    public void NormalCase()
    {
        var solution = new Solution();
        var n = 1;
        var expected = 22;
        var actual = solution.NextBeautifulNumber(n);
        Assert.AreEqual(expected, actual);

        n = 1000;
        expected = 1333;
        actual = solution.NextBeautifulNumber(n);
        Assert.AreEqual(expected, actual);

        n = 3000;
        expected = 3133;
        actual = solution.NextBeautifulNumber(n);
        Assert.AreEqual(expected, actual);

        n = 748601;
        expected = 1224444;
        actual = solution.NextBeautifulNumber(n);
        Assert.AreEqual(expected, actual);
    }
}