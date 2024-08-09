using JetBrains.Annotations;
using source._3100._3132;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3132
{
    private Solution _solution = new();

    [TestMethod]
    public void Test_WhenNormalCase_ShouldPass()
    {
        int[] nums1 = [4, 20, 16, 12, 8];
        int[] nums2 = [14, 18, 10];
        Assert.AreEqual(-2, _solution.MinimumAddedInteger(nums1, nums2));

        nums1 = [3, 5, 5, 3];
        nums2 = [7, 7];
        Assert.AreEqual(2, _solution.MinimumAddedInteger(nums1, nums2));

        nums1 = [7, 9, 1, 4];
        nums2 = [0, 8];
        Assert.AreEqual(-1, _solution.MinimumAddedInteger(nums1, nums2));
    }

}