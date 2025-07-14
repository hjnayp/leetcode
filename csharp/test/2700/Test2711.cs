using JetBrains.Annotations;
using source._2700._2711;

namespace test._2700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2711
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int[][] grid = [[1, 2, 3], [3, 1, 5], [3, 2, 1]];
        int[][] expected = [[1, 1, 0], [1, 0, 1], [0, 1, 1]];

        int[][] actual = solution.DifferenceOfDistinctValues(grid);
        Check(expected, actual);
    }

    private void Check(int[][] expected, int[][] actual)
    {
        Assert.AreEqual(expected.Length, actual.Length);

        for (int i = 0; i < expected.Length; i++)
        {
            CollectionAssert.AreEqual(expected[i], actual[i]);
        }
    }
}