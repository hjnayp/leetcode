using JetBrains.Annotations;
using source._2900._2952;
using source.InputParsers;

namespace test._2900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2952
{
    [TestMethod]
    public void normal_case()
    {
        Solution s = new();
        int[] coins = ArrayParser.ParseOneDimensionalArray("[1,4,10]");
        int target = 19;
        Assert.AreEqual(2, s.MinimumAddedCoins(coins, target));

        coins = ArrayParser.ParseOneDimensionalArray("[1,4,10,5,7,19]");
        target = 19;
        Assert.AreEqual(1, s.MinimumAddedCoins(coins, target));

        coins = ArrayParser.ParseOneDimensionalArray("[1,1,1]");
        target = 20;
        Assert.AreEqual(3, s.MinimumAddedCoins(coins, target));
    }
}