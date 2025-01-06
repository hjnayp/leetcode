using JetBrains.Annotations;
using source._2200._2274;

namespace test._2200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2274
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int bottom = 2;
        int top = 9;
        int[] special = [4, 6];
        int expected = 3;
        Assert.AreEqual(expected, solution.MaxConsecutive(bottom, top, special));

        bottom = 6;
        top = 8;
        special = [7, 6, 8];
        expected = 0;
        Assert.AreEqual(expected, solution.MaxConsecutive(bottom, top, special));
    }
}