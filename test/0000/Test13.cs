using JetBrains.Annotations;
using source._0000._13;

namespace test._0000;

[TestClass, TestSubject(typeof(Solution))]
public class Test13
{
    private readonly Solution _solution = new();
    [TestMethod]
    public void NonePlaceBeforeCase()
    {
        string s = "III";
        Assert.AreEqual(3, _solution.RomanToInt(s));

        s = "MD";
        Assert.AreEqual(1500, _solution.RomanToInt(s));

        s = "LVIII";
        Assert.AreEqual(58, _solution.RomanToInt(s));
    }
    
    [TestMethod]
    public void PlaceBeforeCase()
    {
        string s = "IV";
        Assert.AreEqual(4, _solution.RomanToInt(s));

        s = "IX";
        Assert.AreEqual(9, _solution.RomanToInt(s));

        s = "XL";
        Assert.AreEqual(40, _solution.RomanToInt(s));

        s = "XC";
        Assert.AreEqual(90, _solution.RomanToInt(s));

        s = "CD";
        Assert.AreEqual(400, _solution.RomanToInt(s));

        s = "CM";
        Assert.AreEqual(900, _solution.RomanToInt(s));
        
        s = "MCMXCIV";
        Assert.AreEqual(1994, _solution.RomanToInt(s));
    }
}