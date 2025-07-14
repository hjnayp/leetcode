using JetBrains.Annotations;
using source._2700._2717;

namespace test._2700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2717
{
    private Solution solution = new();

    [TestMethod]
    public void TestSolution()
    {
        int[] nums = [2, 1, 4, 3];
        Assert.AreEqual(2, solution.SemiOrderedPermutation(nums));

        nums = [2, 4, 1, 3];
        Assert.AreEqual(3, solution.SemiOrderedPermutation(nums));

        nums = [1, 3, 4, 2, 5];
        Assert.AreEqual(0, solution.SemiOrderedPermutation(nums));
    }

    [TestMethod]
    public void TestSolution_WhenAllNumAreSame()
    {
        int[] nums = [1, 1, 1];
        Assert.AreEqual(0, solution.SemiOrderedPermutation(nums));
    }
}