using JetBrains.Annotations;
using source._3200._3216;

namespace test._3200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3216
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        Assert.AreEqual("43520", solution.GetSmallestString("45320"));
        Assert.AreEqual("12335", solution.GetSmallestString("12353"));
        Assert.AreEqual("001", solution.GetSmallestString("001"));
    }
}