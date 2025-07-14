using JetBrains.Annotations;
using source._2500._2580;

namespace test._2500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2580
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();

        var ranges = new[]
        {
            new[] { 6, 10 },
            new[] { 5, 15 }
        };
        Assert.AreEqual(2, solution.CountWays(ranges));

        ranges = new[]
        {
            new[] { 1, 3 },
            new[] { 10, 20 },
            new[] { 2, 5 },
            new[] { 4, 8 }
        };
        Assert.AreEqual(4, solution.CountWays(ranges));
    }
}