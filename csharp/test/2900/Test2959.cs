using JetBrains.Annotations;
using source._2900._2959;

namespace test._2900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2959
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        int n = 3;
        int maxDistance = 5;
        int[][] roads =
        [
            [0, 1, 2],
            [1, 2, 10],
            [0, 2, 10]
        ];

        Assert.AreEqual(5, solution.NumberOfSets(n, maxDistance, roads));
    }

    [TestMethod]
    public void two_edge_between_branches()
    {
        Solution solution = new();
        int n = 3;
        int maxDistance = 5;
        int[][] roads =
        [
            [0, 1, 20],
            [0, 1, 10],
            [1, 2, 2],
            [0, 2, 2]
        ];

        Assert.AreEqual(7, solution.NumberOfSets(n, maxDistance, roads));
    }

    [TestMethod]
    public void normal_case_2()
    {
        Solution solution = new();
        int n = 4;
        int maxDistance = 3;
        int[][] roads =
        [
            [2, 1, 8],
            [1, 0, 3],
            [0, 3, 8]
        ];

        Assert.AreEqual(6, solution.NumberOfSets(n, maxDistance, roads));
    }

    [TestMethod]
    public void one_branch_case()
    {
        Solution solution = new();
        int n = 1;
        int maxDistance = 10;
        int[][] roads = [];

        Assert.AreEqual(2, solution.NumberOfSets(n, maxDistance, roads));
    }
}