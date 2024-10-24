using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using source._0000._46;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test46
{
    private Solution _solution = new();

    [TestMethod]
    public void TestSolution()
    {
        int[] nums = [1, 2, 3];
        int[][] expected = [[1, 2, 3], [1, 3, 2], [2, 3, 1], [2, 1, 3], [3, 1, 2], [3, 2, 1]];
        TestCase(nums, expected);

        nums = [0, 1];
        expected = [[0, 1], [1, 0]];
        TestCase(nums, expected);

        nums = [1];
        expected = [[1]];
        TestCase(nums, expected);
    }

    [ExcludeFromCodeCoverage]
    private void TestCase(int[] nums, int[][] expected)
    {
        IList<IList<int>> actual = _solution.Permute(nums);
        Assert.IsTrue(actual.Count == expected.Length);
        for (int i = 0; i < expected.Length; i++)
        {
            CollectionAssert.AreEqual(expected[i], actual[i].ToArray());
        }
    }
}