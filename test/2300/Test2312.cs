using JetBrains.Annotations;
using source._2300._2312;

namespace test._2300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2312
{

    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var m = 3;
        var n = 5;
        int[][] prices =
        {
            new[] { 1, 4, 2 },
            new[] { 2, 2, 7 },
            new[] { 2, 1, 3 },
        };

        long expected = 19;
        long actual = solution.SellingWood(m, n, prices);
        Assert.AreEqual(expected, actual);
    }
}