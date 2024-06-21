using JetBrains.Annotations;
using source.InputParsers;
using source.Lcp._61;

namespace test.Lcp;

[TestClass]
[TestSubject(typeof(Solution))]
public class TestLcp61
{
    private Solution _solution = new();

    [TestMethod]
    public void normal_case()
    {
        int[] temperatureA;
        int[] temperatureB;

        temperatureA = ArrayParser.ParseOneDimensionalArray<int>("[21,18,18,18,31]");
        temperatureB = ArrayParser.ParseOneDimensionalArray<int>("[34,32,16,16,17]");
        Assert.AreEqual(2, _solution.TemperatureTrend(temperatureA, temperatureB));

        temperatureA = ArrayParser.ParseOneDimensionalArray<int>("[5,10,16,-6,15,11,3]");
        temperatureB = ArrayParser.ParseOneDimensionalArray<int>("[16,22,23,23,25,3,-16]");
        Assert.AreEqual(3, _solution.TemperatureTrend(temperatureA, temperatureB));

        temperatureA = ArrayParser.ParseOneDimensionalArray<int>("[-14,7,-19,9,13,40,19,15,-18]");
        temperatureB = ArrayParser.ParseOneDimensionalArray<int>("[3,16,28,32,25,12,13,-6,4]");
        Assert.AreEqual(1, _solution.TemperatureTrend(temperatureA, temperatureB));
    }
}