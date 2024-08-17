using JetBrains.Annotations;
using source._3100._3152;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3152
{
    [TestMethod]
    public void NormalCase()
    {
        Solution solution = new();
        int[] nums = [3, 4, 1, 2, 6];
        int[][] queries = [[0, 4]];
        bool[] expected = [false];
        CollectionAssert.AreEqual(expected, solution.IsArraySpecial(nums, queries));

        nums = [4, 3, 1, 6];
        queries = [[0, 2], [2, 3]];
        expected = [false, true];
        CollectionAssert.AreEqual(expected, solution.IsArraySpecial(nums, queries));

        nums = [3, 6, 2, 1];
        queries = [[0, 1]];
        expected = [true];
        CollectionAssert.AreEqual(expected, solution.IsArraySpecial(nums, queries));

        nums = [5, 1, 5];
        queries = [[0, 1]];
        expected = [false];
        CollectionAssert.AreEqual(expected, solution.IsArraySpecial(nums, queries));
    }

    [TestMethod]
    public void TestSolution_WhenOnlyOneElementInNums_ShouldBeTrue()
    {
        Solution solution = new();
        int[][] queries = [[0, 0]];
        bool[] expected = [true];

        int[] nums = [3];
        CollectionAssert.AreEqual(expected, solution.IsArraySpecial(nums, queries));

        nums = [2];
        CollectionAssert.AreEqual(expected, solution.IsArraySpecial(nums, queries));
    }

    [TestMethod]
    public void TestSolution_WhenTwoElement()
    {
        Solution solution = new();
        int[] nums = [1, 1];
        int[][] queries = [[0, 1]];
        bool[] expected = [false];
        CollectionAssert.AreEqual(expected, solution.IsArraySpecial(nums, queries));

        nums = [1, 2];
        queries = [[0, 1]];
        expected = [true];
        CollectionAssert.AreEqual(expected, solution.IsArraySpecial(nums, queries));

        nums = [2, 2];
        queries = [[0, 0]];
        expected = [true];
        CollectionAssert.AreEqual(expected, solution.IsArraySpecial(nums, queries));
    }
}