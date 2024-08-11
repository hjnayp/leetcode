using JetBrains.Annotations;
using source._1000._1035;

namespace test._1000;

[TestClass, TestSubject(typeof(Solution))]
public class Test1035
{

    [TestMethod]
    public void Method_WhenCommonCase_ShouldPass()
    {
        var solution = new Solution();
        int[] nums1 = [1, 4, 2];
        int[] nums2 = [1, 2, 4];
        Assert.AreEqual(2, solution.MaxUncrossedLines(nums1, nums2));
        
        nums1 = [2, 5, 1, 2, 5];
        nums2 = [10, 5, 2, 1, 5, 2];
        Assert.AreEqual(3,solution.MaxUncrossedLines(nums1, nums2));

        nums1 = [1, 3, 7, 1, 7, 5];
        nums2 = [1, 9, 2, 5, 1];
        Assert.AreEqual(2, solution.MaxUncrossedLines(nums1, nums2));
    }
}