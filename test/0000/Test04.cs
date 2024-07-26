using JetBrains.Annotations;
using source._0000._04;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test04
{
    [TestMethod]
    public void NormalCase()
    {
        Solution solution = new();
        int[] nums1 = [1, 3];
        int[] nums2 = [2];
        Assert.AreEqual(2.0, solution.FindMedianSortedArrays(nums1, nums2));

        nums1 = [1, 2];
        nums2 = [3, 4];
        Assert.AreEqual(2.5, solution.FindMedianSortedArrays(nums1, nums2));

        nums1 = [10, 20];
        nums2 = [3, 4];
        Assert.AreEqual(7, solution.FindMedianSortedArrays(nums1, nums2));
    }

    [TestMethod]
    public void EmptyListCase()
    {
        Solution solution = new();
        int[] nums1 = [];
        int[] nums2 = [2, 3];
        Assert.AreEqual(2.5, solution.FindMedianSortedArrays(nums1, nums2));

        nums1 = [1, 9];
        nums2 = [];
        Assert.AreEqual(5.0, solution.FindMedianSortedArrays(nums1, nums2));
    }
}