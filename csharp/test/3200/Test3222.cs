using JetBrains.Annotations;
using source._3200._3222;

namespace test._3200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3222
{
    private Solution _solution = new();

    [TestMethod]
    public void TestSolution()
    {
        int x = 2;
        int y = 7;
        string output = "Alice";
        Assert.AreEqual(output, _solution.LosingPlayer(x, y));

        x = 4;
        y = 11;
        output = "Bob";
        Assert.AreEqual(output, _solution.LosingPlayer(x, y));
    }
}