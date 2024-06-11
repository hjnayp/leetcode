using JetBrains.Annotations;
using source._0300;
using source.InputParsers;

namespace test._0300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test312
{
    [TestMethod]
    public void normal_case()
    {
        Solution s = new();
        Assert.AreEqual(167, s.MaxCoins(ArrayParser.ParseOneDimensionalArray<int>("[3,1,5,8]")));
        Assert.AreEqual(10, s.MaxCoins(ArrayParser.ParseOneDimensionalArray<int>("[1,5]")));
    }
}