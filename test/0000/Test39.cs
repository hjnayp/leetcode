using System.Diagnostics.CodeAnalysis;
using source._0000._39;

namespace test._0000;

[TestClass]
public class Test39
{
    private Solution _solution;

    [TestInitialize]
    public void TestInitialize()
    {
        _solution = new Solution();
    }

    [TestMethod]
    [Timeout(1000)]
    public void TestCombinationSum()
    {
        IList<IList<int>> result = _solution.CombinationSum(new int[] { 2, 3, 6, 7 }, 7);
        var expected = new List<List<int>>
        {
            new() { 2, 2, 3 },
            new() { 7 },
        };
        AssertEqual(expected, result);

        result = _solution.CombinationSum(new int[] { 1, 2 }, 1);
        expected = [[1]];
        AssertEqual(expected, result);

        result = _solution.CombinationSum([2, 3, 5], 8);
        expected = [[2, 2, 2, 2], [2, 3, 3], [3, 5]];
        AssertEqual(expected, result);

        // Edge case: target is 0
        result = _solution.CombinationSum([2], 1);
        expected = [];
        AssertEqual(expected, result);
    }

    [ExcludeFromCodeCoverage]
    private void AssertEqual(List<List<int>> a, IList<IList<int>> b)
    {
        if (a.Count != b.Count) throw new Exception("Count mismatch");

        a = a.OrderBy(x => string.Join(",", x)).ToList();
        b = b.OrderBy(x => string.Join(",", x)).ToList();

        if (a.Where((t, i) => !t.SequenceEqual(b[i])).Any())
        {
            throw new Exception("Sequence mismatch");
        }
    }
}