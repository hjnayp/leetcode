using JetBrains.Annotations;
using source.LCR._060;

namespace test.LCR;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test060
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();
        int[] nums = [1, 1, 1, 2, 2, 3];
        int k = 2;
        int[] res = [1, 2];
        CollectionAssert.AreEquivalent(res, solution.TopKFrequent(nums, k));

        nums = [1];
        k = 1;
        res = [1];
        CollectionAssert.AreEquivalent(res, solution.TopKFrequent(nums, k));

        nums = [1, 1, 1, 2, 2, 2, 2, 2];
        k = 1;
        res = [2];
        CollectionAssert.AreEquivalent(res, solution.TopKFrequent(nums, k));
    }
}