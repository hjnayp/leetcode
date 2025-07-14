using JetBrains.Annotations;
using source._2900._2951;

namespace test._2900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2951
{
    [TestMethod]
    public void no_peak_case()
    {
        var solution = new Solution();
        int[] mountain = new[] { 2, 4, 4 };
        int[] expected = Array.Empty<int>();
        CollectionAssert.AreEquivalent(expected, solution.FindPeaks(mountain).ToArray());

        mountain = new[] { 1, 1, 3 };
        expected = Array.Empty<int>();
        CollectionAssert.AreEquivalent(expected, solution.FindPeaks(mountain).ToArray());
    }

    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int[] mountain = new[] { 1, 4, 3, 8, 5 };
        int[] expected = new[] { 1, 3 };
        CollectionAssert.AreEquivalent(expected, solution.FindPeaks(mountain).ToArray());
    }
}