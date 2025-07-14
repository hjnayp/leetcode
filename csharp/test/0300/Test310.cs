using JetBrains.Annotations;
using source._0300._310;

namespace test._0300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test310
{

    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var n = 4;
        int[][] edges =
        {
            new[] { 1, 0 },
            new[] { 1, 2 },
            new[] { 1, 3 },
        };
        int[] expected = { 1 };
        IList<int> actual = solution.FindMinHeightTrees(n, edges);
        CollectionAssert.AreEqual(expected, actual.ToArray());
    }

    [TestMethod]
    public void NormalCase2()
    {
        var solution = new Solution();
        var n = 6;
        int[][] edges =
        {
            new[] { 3, 0 },
            new[] { 1, 3 },
            new[] { 2, 3 },
            new[] { 4, 3 },
            new[] { 5, 4 },
        };
        int[] expected = { 3, 4 };
        int[] actual = solution.FindMinHeightTrees(n, edges).ToArray();
        Array.Sort(actual);
        CollectionAssert.AreEqual(expected, actual);
    }
}