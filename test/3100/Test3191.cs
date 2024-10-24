using JetBrains.Annotations;
using source._3100._3191;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3191
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();

        int[] nums = [0, 1, 1, 1, 0, 0];
        Assert.AreEqual(3, solution.MinOperations(nums));

        nums = [0, 1, 1, 1];
        Assert.AreEqual(-1, solution.MinOperations(nums));
    }
}