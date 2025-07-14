using JetBrains.Annotations;
using source._0000._31;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test31
{
    [TestMethod]
    public void TestSolution()
    {
        RunTest([1, 3, 2], [1, 2, 3]);
        RunTest([1, 2, 3], [3, 2, 1]);
        RunTest([1, 5, 1], [1, 1, 5]);
        RunTest([1, 4, 1, 2, 3, 15, 19], [1, 3, 19, 15, 4, 2, 1]);
    }

    [Timeout(1000)]
    private static void RunTest(int[] expected, int[] nums)
    {
        Solution solution = new();
        solution.NextPermutation(nums);
        CollectionAssert.AreEqual(expected, nums);
    }
}