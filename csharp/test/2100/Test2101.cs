using JetBrains.Annotations;
using source._2100._2101;

namespace test._2100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2101
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        int[][] bombs = [[2, 1, 3], [6, 1, 4]];
        Assert.AreEqual(2, solution.MaximumDetonation(bombs));
    }

    [TestMethod]
    public void normal_case_2()
    {
        Solution solution = new();
        int[][] bombs = [[1, 1, 5], [10, 10, 5]];
        Assert.AreEqual(1, solution.MaximumDetonation(bombs));
    }

    [TestMethod]
    public void normal_case_3()
    {
        Solution solution = new();
        int[][] bombs = [[1, 2, 3], [2, 3, 1], [3, 4, 2], [4, 5, 3], [5, 6, 4]];
        Assert.AreEqual(5, solution.MaximumDetonation(bombs));
    }

    [TestMethod]
    public void normal_case_4()
    {
        Solution solution = new();
        int[][] bombs =
        [
            [54, 95, 4], [99, 46, 3], [29, 21, 3], [96, 72, 8], [49, 43, 3],
            [11, 20, 3], [2, 57, 1], [69, 51, 7], [97, 1, 10], [85, 45, 2],
            [38, 47, 1], [83, 75, 3], [65, 59, 3], [33, 4, 1], [32, 10, 2],
            [20, 97, 8], [35, 37, 3]
        ];
        Assert.AreEqual(1, solution.MaximumDetonation(bombs));
    }
}