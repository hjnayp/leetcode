using JetBrains.Annotations;
using source._2700._2766;

namespace test._2700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2766
{
    private static int[] _expected = [5, 6, 8, 9];

    [TestMethod]
    public void normal_case_0()
    {
        Solution solution = new();
        int[] nums = [1, 6, 7, 8];
        int[] moveFrom = [1, 7, 2];
        int[] moveTo = [2, 9, 5];
        _expected = [5, 6, 8, 9];
        CollectionAssert.AreEqual(_expected, solution.RelocateMarbles(nums, moveFrom, moveTo).ToArray());
    }

    [TestMethod]
    public void normal_case_1()
    {
        Solution solution = new();
        int[] nums = [1, 1, 3, 3];
        int[] moveFrom = [1, 3];
        int[] moveTo = [2, 2];
        _expected = [2];
        CollectionAssert.AreEqual(_expected, solution.RelocateMarbles(nums, moveFrom, moveTo).ToArray());
    }

    [TestMethod]
    public void have_invalid_operation()
    {
        Solution solution = new();
        int[] nums = [1, 2];
        int[] moveFrom = [1, 5];
        int[] moveTo = [1, 2];
        _expected = [1,2];
        CollectionAssert.AreEqual(_expected, solution.RelocateMarbles(nums, moveFrom, moveTo).ToArray());
    }
}