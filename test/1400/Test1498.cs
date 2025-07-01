using JetBrains.Annotations;
using source._1400._1498;

namespace test._1400;

[TestClass, TestSubject(typeof(Solution))]
public class Test1498
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();
        int[] nums = [];
        int target = 0;
        int expected = 0;
        int actual = 0;

        nums = [3, 5, 6, 7];
        target = 9;
        expected = 4;
        actual = solution.NumSubseq(nums, target);
        Assert.AreEqual(expected, actual);

        nums = [3, 3, 6, 8];
        target = 10;
        expected = 6;
        actual = solution.NumSubseq(nums, target);
        Assert.AreEqual(expected, actual);

        nums = [2, 3, 3, 4, 6, 7];
        target = 12;
        expected = 61;
        actual = solution.NumSubseq(nums, target);
        Assert.AreEqual(expected, actual);
    }
}