using JetBrains.Annotations;
using source._3100._3131;

namespace test._3100;

[TestClass, TestSubject(typeof(Solution))]
public class Test3131
{
    private readonly Solution _solution = new();

    [TestMethod]
    public void NormalCase()
    {
        int[] nums1 = [2, 6, 4];
        int[] nums2 = [9, 7, 5];
        Assert.AreEqual(3, _solution.AddedInteger(nums1, nums2));

        nums1 = [10];
        nums2 = [5];
        Assert.AreEqual(-5, _solution.AddedInteger(nums1, nums2));

        nums1 = [1, 2, 3];
        nums2 = [1, 2, 3];
        Assert.AreEqual(0, _solution.AddedInteger(nums1, nums2));
    }
}