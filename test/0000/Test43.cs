using JetBrains.Annotations;
using source._0000._43;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test43
{
    [TestMethod, Timeout(1000)]
    public void TestSolution()
    {
        var solution = new Solution();

        Assert.AreEqual("6", solution.Multiply("2", "3"));
        Assert.AreEqual("20", solution.Multiply("2", "10"));
        Assert.AreEqual("12", solution.Multiply("2", "6"));
        Assert.AreEqual("56088", solution.Multiply("123", "456"));
        Assert.AreEqual("0", solution.Multiply("0", "0"));
        Assert.AreEqual("0", solution.Multiply("120", "0"));
    }
}