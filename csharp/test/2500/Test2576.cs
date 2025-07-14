using JetBrains.Annotations;
using source._2500._2576;

namespace test._2500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2576
{
    [TestMethod]
    [Timeout(2000)]
    public void TestSolution()
    {
        var solution = new Solution();
        int[] nums = [3, 5, 2, 4];
        Assert.AreEqual(2, solution.MaxNumOfMarkedIndices(nums));

        nums = [9, 2, 5, 4];
        Assert.AreEqual(4, solution.MaxNumOfMarkedIndices(nums));

        nums = [7, 6, 8];
        Assert.AreEqual(0, solution.MaxNumOfMarkedIndices(nums));

        nums = [42, 83, 48, 10, 24, 55, 9, 100, 10, 17, 17, 99, 51, 32, 16, 98, 99, 31, 28, 68, 71, 14, 64, 29, 15, 40];
        Assert.AreEqual(26, solution.MaxNumOfMarkedIndices(nums));
        
        nums =
        [
            1, 78, 27, 48, 14, 86, 79, 68, 77, 20, 57, 21, 18, 67, 5, 51, 70, 85, 47, 56, 22, 79, 41, 8, 39, 81, 59, 74,
            14, 45, 49, 15, 10, 28, 16, 77, 22, 65, 8, 36, 79, 94, 44, 80, 72, 8, 96, 78, 39, 92, 69, 55, 9, 44, 26, 76,
            40, 77, 16, 69, 40, 64, 12, 48, 66, 7, 59, 10
        ];
        Assert.AreEqual(64, solution.MaxNumOfMarkedIndices(nums));
    }
}