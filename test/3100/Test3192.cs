using JetBrains.Annotations;
using source._3100._3192;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3192
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int[] nums = [0, 1, 1, 0, 1];
        int expected = 4;
        Assert.AreEqual(expected, solution.MinOperations(nums));

        nums = [1, 0, 0, 0];
        expected = 1;
        Assert.AreEqual(expected, solution.MinOperations(nums));
    }
}