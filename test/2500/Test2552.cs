using JetBrains.Annotations;
using source._2500._2552;

namespace test._2500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2552
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int[] nums = [1, 3, 2, 4, 5];
        Assert.AreEqual(2, solution.CountQuadruplets(nums));

        nums = [1, 2, 3, 4];
        Assert.AreEqual(0, solution.CountQuadruplets(nums));
        
        nums = [2, 5, 3, 1, 4];
        Assert.AreEqual(0, solution.CountQuadruplets(nums));
    }
}