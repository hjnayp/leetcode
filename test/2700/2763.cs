using source._2700._2736;

namespace test._2700;

[TestClass]
public class Test2736
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var nums1 = new[] { 4, 3, 1, 2 };
        var nums2 = new[] { 2, 4, 9, 5 };
        var queries = new[]
        {
            new[] { 4, 1 },
            new[] { 1, 3 },
            new[] { 2, 5 },
        };

        var expected = new[] { 6, 10, 7 };
        var actual = solution.MaximumSumQueries(nums1, nums2, queries);
        CollectionAssert.AreEqual(expected, actual);
    }
}