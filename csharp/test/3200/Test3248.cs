using JetBrains.Annotations;
using source._3200._3248;

namespace test._3200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3248
{
    private Solution solution = new();
    private int n;
    private string[] commands;

    [TestMethod]
    public void TestSolution_WhenCommonCase()
    {
        n = 2;
        commands = ["RIGHT", "DOWN"];
        Assert.AreEqual(3, solution.FinalPositionOfSnake(n, commands));

        n = 3;
        commands = ["DOWN", "RIGHT", "UP"];
        Assert.AreEqual(1, solution.FinalPositionOfSnake(n, commands));

        n = 3;
        commands = ["DOWN", "RIGHT", "UP", "LEFT"];
        Assert.AreEqual(0, solution.FinalPositionOfSnake(n, commands));
    }

    [TestMethod]
    public void TestSolution_WhenContainInvalidOperation()
    {
        n = 3;
        commands = ["DOWN", "RIGHT", "UP", "INVALID_OPERATION"];
        Assert.AreEqual(1, solution.FinalPositionOfSnake(n, commands));
    }
}