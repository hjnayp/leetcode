using JetBrains.Annotations;
using source._3100._3176;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3176
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int[] nums = [1, 2, 1, 1, 3];
        int k = 2;
        Assert.AreEqual(4, solution.MaximumLength(nums, k));

        nums = [1, 2, 3, 4, 5, 1];
        k = 0;
        Assert.AreEqual(2, solution.MaximumLength(nums, k));
    }
}