using JetBrains.Annotations;
using source._2700._2748;
using source.InputParsers;

namespace test._2700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2748
{
    private Solution _solution = new();

    [TestMethod]
    public void normal_case()
    {
        int[] nums;

        nums = ArrayParser.ParseOneDimensionalArray<int>("[2,5,1,4]");
        Assert.AreEqual(5, _solution.CountBeautifulPairs(nums));

        nums = ArrayParser.ParseOneDimensionalArray<int>("[11,21,12]");
        Assert.AreEqual(2, _solution.CountBeautifulPairs(nums));

        nums = ArrayParser.ParseOneDimensionalArray<int>(
            "[756,1324,2419,495,106,111,1649,1474,2001,1633,273,1804,2102,1782,705,1529,1761,1613,111,186,412]");
        Assert.AreEqual(183, _solution.CountBeautifulPairs(nums));
    }
}