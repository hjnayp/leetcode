using JetBrains.Annotations;
using source._0000._18;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test18
{
    [TestMethod]
    public void NormalCase()
    {
        RunTestCase(
            [[-2, -1, 1, 2], [-2, 0, 0, 2], [-1, 0, 0, 1]],
            [1, 0, -1, 0, -2, 2],
            0
        );
        RunTestCase(
            [[2, 2, 2, 2]],
            [2, 2, 2, 2, 2],
            8
        );
        RunTestCase(
            [],
            [2, 2, 2, 2, 2],
            100
        );
        RunTestCase(
            [[0, 10, 10, 80]],
            [0, 0, 10, 10, 80],
            100
        );
    }

    [TestMethod]
    public void Solution_WhenSumOverFlow()
    {
        RunTestCase(
            [[0, 0, 0, 1000000000]],
            [0, 0, 0, 1000000000, 1000000000, 1000000000, 1000000000],
            1000000000
        );
    }

    [TestMethod]
    public void Solution_WhenNumsLengthSmallerThan4_ShouldReturnEmpty()
    {
        RunTestCase(
            [],
            [0, 0, 0],
            1000000000
        );
    }

    private void RunTestCase(int[][] expected, int[] nums, int target)
    {
        var solution = new Solution();
        int[][] result = solution.FourSum(nums, target).Select(x => x.ToArray()).ToArray();

        Assert.AreEqual(expected.Length, result.Length);
        for (int i = 0; i < expected.Length; i++)
        {
            CollectionAssert.AreEqual(expected[i], result[i]);
        }
    }
}