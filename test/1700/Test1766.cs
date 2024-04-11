using JetBrains.Annotations;
using source._1700._1766;

namespace test._1700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1766
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var nums = new[] { 2, 3, 3, 2 };
        var edges = new[]
        {
            new[] { 0, 1 },
            new[] { 1, 2 },
            new[] { 1, 3 }
        };

        int[] actual = solution.GetCoprimes(nums, edges);
        int[] expected = { -1, 0, 0, 1 };
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void NormalCase2()
    {
        var solution = new Solution();
        var nums = new[] { 5, 6, 10, 2, 3, 6, 15 };
        var edges = new[]
        {
            new[] { 0, 1 },
            new[] { 0, 2 },
            new[] { 1, 3 },
            new[] { 1, 4 },
            new[] { 2, 5 },
            new[] { 2, 6 }
        };

        int[] actual = solution.GetCoprimes(nums, edges);
        int[] expected = { -1, 0, -1, 0, 0, 0, -1 };
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void NormalCase3()
    {
        var solution = new Solution();
        var nums = new[] { 1 };
        var edges = new int[][] { };

        int[] actual = solution.GetCoprimes(nums, edges);
        int[] expected = { -1 };
        CollectionAssert.AreEqual(expected, actual);
    }
}