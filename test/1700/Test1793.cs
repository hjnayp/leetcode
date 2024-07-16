using JetBrains.Annotations;
using source._1700._1793;

namespace test._1700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1793
{
    [TestMethod]
    public void normal_case_1()
    {
        Solution solution = new();
        int[] nums = [1, 4, 3, 7, 4, 5];
        int k = 3;
        int expected = 15;
        int actual = solution.MaximumScore(nums, k);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void normal_case_2()
    {
        Solution solution = new();
        int[] nums = [5, 5, 4, 5, 4, 1, 1, 1];
        int k = 0;
        int expected = 20;
        int actual = solution.MaximumScore(nums, k);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void all_same_element()
    {
        Solution solution = new();
        int[] nums = [2, 2, 2];
        int k = 1;
        int expected = 6;
        int actual = solution.MaximumScore(nums, k);
        Assert.AreEqual(expected, actual);
    }
}