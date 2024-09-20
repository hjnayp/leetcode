using JetBrains.Annotations;
using source._2300._2376;

namespace test._2300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2376
{
    [TestMethod]
    public void TestSolution()
    {
        RunTest(5, 5);
        RunTest(19, 20);
        RunTest(110, 135);
        RunTest(985991, 25637815);
    }

    static void RunTest(int expected, int input)
    {
        var solution = new Solution();
        Assert.AreEqual(expected, solution.CountSpecialNumbers(input));
    }
}