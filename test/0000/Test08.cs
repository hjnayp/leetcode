using JetBrains.Annotations;
using source._0000._08;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test08
{
    [TestMethod]
    public void Common_Case()
    {
        var solution = new Solution();
        Assert.AreEqual(42, solution.MyAtoi("42"));
        Assert.AreEqual(999, solution.MyAtoi("999"));
        Assert.AreEqual(-42, solution.MyAtoi("-42"));
        Assert.AreEqual(-999, solution.MyAtoi("-999"));
    }

    [TestMethod]
    public void LeadingZero()
    {
        var solution = new Solution();
        Assert.AreEqual(42, solution.MyAtoi("042"));
        Assert.AreEqual(999, solution.MyAtoi("0999"));
        Assert.AreEqual(-42, solution.MyAtoi("-042"));
        Assert.AreEqual(-999, solution.MyAtoi("-0999"));
    }

    [TestMethod]
    public void LeadingSpace()
    {
        var solution = new Solution();
        Assert.AreEqual(42, solution.MyAtoi("  042"));
        Assert.AreEqual(999, solution.MyAtoi("  0999"));
        Assert.AreEqual(-42, solution.MyAtoi("  -042"));
        Assert.AreEqual(-999, solution.MyAtoi("  -0999"));
        Assert.AreEqual(0, solution.MyAtoi("  0-0999"));
    }

    [TestMethod]
    public void WithInvalidCharacter()
    {
        var solution = new Solution();
        Assert.AreEqual(42, solution.MyAtoi("  042-78965"));
        Assert.AreEqual(999, solution.MyAtoi("  0999.26"));
        Assert.AreEqual(-42, solution.MyAtoi("  -042+45"));
        Assert.AreEqual(-999, solution.MyAtoi("  -0999   24325"));
        Assert.AreEqual(1337, solution.MyAtoi("1337c0d3"));
        Assert.AreEqual(0, solution.MyAtoi(".1"));
    }

    [TestMethod]
    public void RangeEdgeCase()
    {
        var solution = new Solution();
        Assert.AreEqual(2147483647, solution.MyAtoi("2147483647"));
        Assert.AreEqual(2147483647, solution.MyAtoi("2147483648"));
        Assert.AreEqual(-2147483648, solution.MyAtoi("-2147483648"));
        Assert.AreEqual(-2147483648, solution.MyAtoi("-2147483649"));
    }
}