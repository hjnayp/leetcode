using JetBrains.Annotations;
using source._0000._40;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test40
{
    [TestMethod, Timeout(1000)]
    public void TestSolution()
    {
        RunTestCase([
            [1, 1, 6],
            [1, 2, 5],
            [1, 7],
            [2, 6],
        ], [10, 1, 2, 7, 6, 1, 5], 8);
        RunTestCase([
            [1, 2, 2],
            [5],
        ], [2, 5, 2, 1, 2], 5);
    }

    private static void RunTestCase(int[][] expected, int[] candidates, int target)
    {
        var solution = new Solution();
        IList<IList<int>> result = solution.CombinationSum2(candidates, target);
        Assert.AreEqual(result.Count, expected.Length);
        for (int i = 0; i < expected.Length; i++)
        {
            int[] list = result[i].ToArray();
            int[] list2 = expected[i];
            CollectionAssert.AreEqual(list2, list);
        }
    }
}