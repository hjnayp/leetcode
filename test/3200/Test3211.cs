using source._3200._3200._3211;

namespace test._3200;

[TestClass]
public class Test3211
{
    private Solution _solution;

    [TestInitialize]
    public void TestInitialize()
    {
        _solution = new Solution();
    }

    [TestMethod]
    public void TestValidStrings_WhenNIs3()
    {
        var result = _solution.ValidStrings(3);
        Assert.AreEqual(5, result.Count());
        string[] expected = ["010", "011", "101", "110", "111"];
        CollectionAssert.AreEqual(expected, result.ToArray());
    }

    [TestMethod]
    public void TestValidStrings_WhenNIs1()
    {
        var result = _solution.ValidStrings(1);
        Assert.AreEqual(2, result.Count());
        string[] expected = ["0", "1"];
        CollectionAssert.AreEqual(expected, result.ToArray());
    }
}