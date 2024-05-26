using JetBrains.Annotations;
using source._1700._1738;

namespace test._1700;

[TestClass, TestSubject(typeof(Solution))]
public class Test1738
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int[][] matrix = { new[] { 5, 2 }, new[] { 1, 6 } };
        int k = 1;
        Assert.AreEqual(7, solution.KthLargestValue(matrix, k));

        matrix = new[] { new[] { 5, 2 }, new[] { 1, 6 } };
        k = 2;
        Assert.AreEqual(5, solution.KthLargestValue(matrix, k));
        k = 3;
        Assert.AreEqual(4, solution.KthLargestValue(matrix, k));
    }
}