using JetBrains.Annotations;
using source._2900._2956;

namespace test._2900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2956
{
    [TestMethod]
    public void normal_case1()
    {
        Solution solution = new();
        int[] nums1 = [2, 3, 2];
        int[] nums2 = [1, 2];
        int[] expected = [2, 1];
        CollectionAssert.AreEqual(expected, solution.FindIntersectionValues(nums1, nums2));
    }

    [TestMethod]
    public void normal_case2()
    {
        Solution solution = new();
        int[] nums1 = [4, 3, 2, 3, 1];
        int[] nums2 = [2, 2, 5, 2, 3, 6];
        int[] expected = [3, 4];
        CollectionAssert.AreEqual(expected, solution.FindIntersectionValues(nums1, nums2));
    }

    [TestMethod]
    public void both_no_common_between_two_arr()
    {
        Solution solution = new();
        int[] nums1 = [3, 4, 2, 3];
        int[] nums2 = [1, 5];
        int[] expected = [0, 0];
        CollectionAssert.AreEqual(expected, solution.FindIntersectionValues(nums1, nums2));
    }
}