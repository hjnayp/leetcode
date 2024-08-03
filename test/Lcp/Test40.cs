using JetBrains.Annotations;
using source.Lcp._40;

namespace test.Lcp;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test40
{
    private readonly Solution _solution = new();

    [TestMethod]
    public void AllOddCards_With_OddCardCount()
    {
        int[] cards = [1, 3, 5, 7];
        int cnt = 3;
        Assert.AreEqual(0, _solution.MaxmiumScore(cards, cnt));

        cards = [1, 5, 667, 99999, 7, 5, 15, 169];
        cnt = 5;
        Assert.AreEqual(0, _solution.MaxmiumScore(cards, cnt));
    }

    [TestMethod]
    public void CommonCase()
    {
        int[] cards = [1, 2, 8, 9];
        int cnt = 3;
        Assert.AreEqual(18, _solution.MaxmiumScore(cards, cnt));

        cards = [1, 2, 8, 10, 15, 101, 20, 80];
        cnt = 2;
        Assert.AreEqual(116, _solution.MaxmiumScore(cards, cnt));
        cnt = 1;
        Assert.AreEqual(80, _solution.MaxmiumScore(cards, cnt));

        cards = [10, 20, 30];
        cnt = 2;
        Assert.AreEqual(50, _solution.MaxmiumScore(cards, cnt));
    }
}