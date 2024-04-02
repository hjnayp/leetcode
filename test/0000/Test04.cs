using JetBrains.Annotations;
using source._0000;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test04
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var nums1 = new[] { 1, 3 };
        var nums2 = new[] { 2 };
        Assert.AreEqual(2.0, solution.FindMedianSortedArrays(nums1, nums2));

        nums1 = new[] { 1, 2 };
        nums2 = new[] { 3, 4 };
        Assert.AreEqual(2.5, solution.FindMedianSortedArrays(nums1, nums2));

        nums1 = new[] { 10, 20 };
        nums2 = new[] { 3, 4 };
        Assert.AreEqual(7, solution.FindMedianSortedArrays(nums1, nums2));
    }

    [TestMethod]
    public void EmptyListCase()
    {
        var solution = new Solution();
        var nums1 = new int[] { };
        var nums2 = new[] { 2, 3 };
        Assert.AreEqual(2.5, solution.FindMedianSortedArrays(nums1, nums2));

        nums1 = new[] { 1, 9 };
        nums2 = new int[] { };
        Assert.AreEqual(5.0, solution.FindMedianSortedArrays(nums1, nums2));
    }
}