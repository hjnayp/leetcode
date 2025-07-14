using JetBrains.Annotations;
using source._1300._1329;

namespace test._1300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1329
{
    [TestMethod]
    public void Normal()
    {
        var solution = new Solution();
        int[][] mat =
        {
            new[] { 3, 3, 1, 1 },
            new[] { 2, 2, 1, 2 },
            new[] { 1, 1, 1, 2 }
        };

        int[][] expected =
        {
            new[] { 1, 1, 1, 1 },
            new[] { 1, 2, 2, 2 },
            new[] { 1, 2, 3, 3 }
        };

        int[][] output = solution.DiagonalSort(mat);
        for (int i = 0; i < expected.Length; i++)
            CollectionAssert.AreEquivalent(expected[i], output[i]);
    }

    [TestMethod]
    public void Normal2()
    {
        var solution = new Solution();
        int[][] mat =
        {
            new[] { 11, 25, 66, 1, 69, 7 },
            new[] { 23, 55, 17, 45, 15, 52 },
            new[] { 75, 31, 36, 44, 58, 8 },
            new[] { 22, 27, 33, 25, 68, 4 },
            new[] { 84, 28, 14, 11, 5, 50 }
        };

        int[][] expected =
        {
            new[] { 5, 17, 4, 1, 52, 7 },
            new[] { 11, 11, 25, 45, 8, 69 },
            new[] { 14, 23, 25, 44, 58, 15 },
            new[] { 22, 27, 31, 36, 50, 66 },
            new[] { 84, 28, 75, 33, 55, 68 }
        };

        int[][] output = solution.DiagonalSort(mat);
        for (int i = 0; i < expected.Length; i++)
            CollectionAssert.AreEquivalent(expected[i], output[i]);
    }
}