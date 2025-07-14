using JetBrains.Annotations;
using source._0000._06;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test06
{
    [TestMethod]
    public void Normal()
    {
        var solution = new Solution();
        var s = "PAYPALISHIRING";
        var numRows = 3;
        var expected = "PAHNAPLSIIGYIR";
        Assert.AreEqual(expected, solution.Convert(s, numRows));
    }

    [TestMethod]
    public void Normal2()
    {
        var solution = new Solution();
        var s = "PAYPALISHIRING";
        var numRows = 4;
        var expected = "PINALSIGYAHRPI";
        Assert.AreEqual(expected, solution.Convert(s, numRows));
    }

    [TestMethod]
    public void Normal3()
    {
        var solution = new Solution();
        var s = "A";
        var numRows = 1;
        var expected = "A";
        Assert.AreEqual(expected, solution.Convert(s, numRows));
    }
}