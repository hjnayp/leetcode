using JetBrains.Annotations;
using source._0600._661;

namespace test._0600;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test661
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int[][] img = [[1, 1, 1], [1, 0, 1], [1, 1, 1]];
        int[][] expected = [[0, 0, 0], [0, 0, 0], [0, 0, 0]];

        int[][] output = solution.ImageSmoother(img);
        for (int i = 0; i < expected.Length; i++)
        {
            int[] row = expected[i];
            int[] outputRow = output[i];
            CollectionAssert.AreEqual(row, outputRow);
        }
    }
}