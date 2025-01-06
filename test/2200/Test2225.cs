using JetBrains.Annotations;
using source._2200._2225;

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
            [1, 3], [2, 3], [3, 6],
            [5, 6], [5, 7], [4, 5],
            [4, 8], [4, 9], [10, 4], [10, 9],
        };
        int[][] expected =
        [
            [1, 2, 10],
            [4, 5, 7, 8],
        ];
        IList<IList<int>> result = solution.FindWinners(matches);
        int[][] res = { result[0].ToArray(), result[1].ToArray() };

        for (int i = 0; i < expected.Length; i++)
        {
            CollectionAssert.AreEquivalent(expected[i], res[i]);
        }

        matches =
        [
            [2, 3], [1, 3], [5, 4], [6, 4],
        ];
        expected =
        [
            [1, 2, 5, 6],
            [],
        ];
        result = solution.FindWinners(matches);
        res = [result[0].ToArray(), result[1].ToArray()];

        for (int i = 0; i < expected.Length; i++)
        {
            CollectionAssert.AreEquivalent(expected[i], res[i]);
        }
    }
}