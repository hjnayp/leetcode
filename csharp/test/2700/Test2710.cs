using JetBrains.Annotations;
using source._2700._2710;

namespace test._2700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2710
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();

        string num;

        num = "51230100";
        Assert.AreEqual("512301", solution.RemoveTrailingZeros(num));

        num = "123";
        Assert.AreEqual("123", solution.RemoveTrailingZeros(num));
    }
}