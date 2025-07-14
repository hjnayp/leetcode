using JetBrains.Annotations;
using source._2900._2960;
using source.InputParsers;

namespace test._2900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2960
{
    private Solution _solution = new();
    private IList<int> _batteryPercentages;

    [TestMethod]
    public void normal_case()
    {
        _batteryPercentages = ArrayParser.ParseOneDimensionalArray<int>("[1,1,2,1,3]");
        Assert.AreEqual(3, _solution.CountTestedDevices(_batteryPercentages.ToArray()));

        _batteryPercentages = ArrayParser.ParseOneDimensionalArray<int>("[0,1,2]");
        Assert.AreEqual(2, _solution.CountTestedDevices(_batteryPercentages.ToArray()));
    }
}