using JetBrains.Annotations;
using source._3200._3208;

namespace test._3200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3208
{
    private Solution solution = new();
    private int[] colors;
    private int k;
    private int expected;

    [TestMethod]
    public void TestSolution()
    {
        colors = [0, 1, 0, 1, 0];
        k = 3;
        expected = 3;
        Assert.AreEqual(expected, solution.NumberOfAlternatingGroups(colors, k));

        colors = [0, 1, 0, 0, 1, 0, 1];
        k = 6;
        expected = 2;
        Assert.AreEqual(expected, solution.NumberOfAlternatingGroups(colors, k));

        colors = [1, 1, 0, 1];
        k = 4;
        expected = 0;
        Assert.AreEqual(expected, solution.NumberOfAlternatingGroups(colors, k));
    }
}