using JetBrains.Annotations;
using source._3200._3274;

namespace test._3200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3274
{
    private Solution solution = new();
    private string coordinate1;
    private string coordinate2;
    private bool expected;

    [TestMethod]
    public void TestSolution()
    {
        coordinate1 = "a1";
        coordinate2 = "c3";
        expected = true;
        Assert.AreEqual(expected, solution.CheckTwoChessboards(coordinate1, coordinate2));

        coordinate1 = "a1";
        coordinate2 = "h3";
        expected = false;
        Assert.AreEqual(expected, solution.CheckTwoChessboards(coordinate1, coordinate2));
    }
}