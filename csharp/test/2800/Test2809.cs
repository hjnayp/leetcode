using JetBrains.Annotations;
using source._2800._2809;

namespace test._2800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2809
{
    [TestMethod]
    public void TestCase1()
    {
        var solution = new Solution();
        int[]? nums1 = new[] { 7, 9, 8, 5, 8, 3 };
        int[]? nums2 = new[] { 0, 1, 4, 2, 3, 1 };
        int x = 37;
        int expected = 2;
        Assert.AreEqual(expected, solution.MinimumTime(nums1, nums2, x));
    }
}