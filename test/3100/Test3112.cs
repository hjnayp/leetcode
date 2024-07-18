using JetBrains.Annotations;
using source._3100._3112;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3112
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        int n = 3;
        int[][] edges = [[0, 1, 2], [1, 2, 1], [0, 2, 4]];
        int[] disappear = [1, 1, 5];
        int[] expected = [0, -1, 4];
        CollectionAssert.AreEqual(expected, solution.MinimumTime(n, edges, disappear));
    }

    [TestMethod]
    public void normal_case_2()
    {
        Solution solution = new();
        int n = 3;
        int[][] edges = [[0, 1, 2], [1, 2, 1], [0, 2, 4]];
        int[] disappear = [1, 3, 5];
        int[] expected = [0, 2, 3];
        CollectionAssert.AreEqual(expected, solution.MinimumTime(n, edges, disappear));
    }

    [TestMethod]
    public void normal_case_3()
    {
        Solution solution = new();
        int n = 2;
        int[][] edges = [[0, 1, 1]];
        int[] disappear = [1, 1];
        int[] expected = [0, -1];
        CollectionAssert.AreEqual(expected, solution.MinimumTime(n, edges, disappear));
    }

    [TestMethod]
    public void normal_case_4()
    {
        Solution solution = new();
        int n = 7;
        int[][] edges = [[1, 4, 3], [3, 4, 2], [2, 5, 5], [3, 3, 10]];
        int[] disappear = [10, 1, 13, 1, 7, 1, 19];
        int[] expected = [0, -1, -1, -1, -1, -1, -1];
        CollectionAssert.AreEqual(expected, solution.MinimumTime(n, edges, disappear));
    }

    [TestMethod]
    public void normal_case_5()
    {
        Solution solution = new();
        int n = 8;
        int[][] edges = [[4, 4, 1], [7, 4, 1], [5, 0, 5], [1, 7, 8], [2, 5, 2], [5, 5, 7], [7, 0, 8], [4, 0, 2]];
        int[] disappear = [3, 19, 1, 1, 17, 5, 1, 11];
        int[] expected = [0, 11, -1, -1, 2, -1, -1, 3];
        CollectionAssert.AreEqual(expected, solution.MinimumTime(n, edges, disappear));
    }
}