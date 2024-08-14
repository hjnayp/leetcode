using JetBrains.Annotations;
using source._0000._15;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test15
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int[] nums = [-1, 0, 1, 2, -1, -4];
        int[][] expecteds = [[-1, -1, 2], [-1, 0, 1]];
        AssertIsAsExpected(expecteds, solution.ThreeSum(nums));

        nums = [0, 1, 1];
        expecteds = [];
        AssertIsAsExpected(expecteds, solution.ThreeSum(nums));
        
        nums = [0, 0, 0];
        expecteds = [[0, 0, 0]];
        AssertIsAsExpected(expecteds, solution.ThreeSum(nums));
    }

    void AssertIsAsExpected(IList<IList<int>> expected, IList<IList<int>> actual)
    {
        Assert.AreEqual(expected.Count, actual.Count);
        for (var i = 0; i < expected.Count; i++)
        {
            CollectionAssert.AreEqual(expected[i].ToArray(), actual[i].ToArray());
        }
    }
}