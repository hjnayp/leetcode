using source._0000._70;

namespace test._0000;

[TestClass]
public class Test70
{
    [TestMethod]
    [Timeout(1500)]
    public void NormalCase()
    {
        var n = 2;
        var expected = 2;
        var actual = new Solution().ClimbStairs(n);
        Assert.AreEqual(expected, actual);

        n = 3;
        expected = 3;
        actual = new Solution().ClimbStairs(n);

        n = 45;
        expected = 1836311903;
        actual = new Solution().ClimbStairs(n);
        Assert.AreEqual(expected, actual);
    }
}