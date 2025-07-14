using JetBrains.Annotations;
using source._0900._935;

namespace test._0900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test935
{
    private Solution solution = new();

    [TestMethod]
    public void TestSolution()
    {
        Assert.AreEqual(10, solution.KnightDialer(1));
        Assert.AreEqual(20, solution.KnightDialer(2));
        Assert.AreEqual(136006598, solution.KnightDialer(3131));
    }
}