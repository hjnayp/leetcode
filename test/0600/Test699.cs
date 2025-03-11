using JetBrains.Annotations;
using source._0600._699;

namespace test._0600;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test699
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int[][] positions = [[1, 2], [2, 3], [6, 1]];
        int[] result = solution.FallingSquares(positions).ToArray();
        int[] expected = [2, 5, 5];
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void normal_case_1()
    {
        var solution = new Solution();
        int[][] positions = [[100, 100], [200, 100]];
        int[] result = solution.FallingSquares(positions).ToArray();
        int[] expected = [100, 100];
        CollectionAssert.AreEqual(expected, result);
    }
}