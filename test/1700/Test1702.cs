using JetBrains.Annotations;
using source._1700._1702;

namespace test._1700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1702
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        Assert.AreEqual("111011", solution.MaximumBinaryString("000110"));
        Assert.AreEqual("01", solution.MaximumBinaryString("01"));
        Assert.AreEqual("1110", solution.MaximumBinaryString("1100"));
    }
}