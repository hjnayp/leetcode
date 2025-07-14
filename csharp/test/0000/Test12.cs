using JetBrains.Annotations;
using source._0000._12;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test12
{

    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        Assert.AreEqual("MMMDCCXLIX", solution.IntToRoman(3749));
        Assert.AreEqual("LVIII", solution.IntToRoman(58));
        Assert.AreEqual("MCMXCIV", solution.IntToRoman(1994));
    }
}