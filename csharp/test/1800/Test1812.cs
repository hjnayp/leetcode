using JetBrains.Annotations;
using source._1800._1812;

namespace test._1800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1812
{
    private Solution solution = new();

    [TestMethod]
    public void TestSolution()
    {
        Assert.AreEqual(false, solution.SquareIsWhite("a1"));
        Assert.AreEqual(true, solution.SquareIsWhite("h3"));
        Assert.AreEqual(false, solution.SquareIsWhite("c7"));
    }
}