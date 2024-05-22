using JetBrains.Annotations;
using source._2200;

namespace test._2200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2225
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int[][] matches =
        {
            new[] { 1, 3 }, new[] { 2, 3 }, new[] { 3, 6 },
            new[] { 5, 6 }, new[] { 5, 7 }, new[] { 4, 5 },
            new[] { 4, 8 }, new[] { 4, 9 }, new[] { 10, 4 }, new[] { 10, 9 }
        };
        int[][] expected =
        {
            new[] { 1, 2, 10 },
            new[] { 4, 5, 7, 8 }
        };
        IList<IList<int>> result = solution.FindWinners(matches);
        int[][] res = { result[0].ToArray(), result[1].ToArray() };


        for (int i = 0; i < expected.Length; i++)
        {
            CollectionAssert.AreEquivalent(expected[i], res[i]);
        }

        matches = new[]
        {
            new[] { 2, 3 }, new[] { 1, 3 }, new[] { 5, 4 }, new[] { 6, 4 }
        };
        expected = new[]
        {
            new[] { 1, 2, 5, 6 },
            Array.Empty<int>()
        };
        result = solution.FindWinners(matches);
        res = new[] { result[0].ToArray(), result[1].ToArray() };

        for (int i = 0; i < expected.Length; i++)
        {
            CollectionAssert.AreEquivalent(expected[i], res[i]);
        }
    }
}