using JetBrains.Annotations;
using source._0000._59;
using test.AssertHelpers;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test59
{
    [TestMethod]
    [Timeout(1000)]
    public void TestSolution()
    {
        int n = 3;
        IList<IList<int>> expected = [[1, 2, 3], [8, 9, 4], [7, 6, 5]];
        var solution = new Solution();
        Assert.IsTrue(TwoDimensionalArrayAssert.AreEquivalent(expected, solution.GenerateMatrix(n)));

        n = 1;
        expected = [[1]];
        Assert.IsTrue(TwoDimensionalArrayAssert.AreEquivalent(expected, solution.GenerateMatrix(n)));

        n = 2;
        expected = [[1, 2], [4, 3]];
        Assert.IsTrue(TwoDimensionalArrayAssert.AreEquivalent(expected, solution.GenerateMatrix(n)));
    }
}