using JetBrains.Annotations;
using source._0500._540;

namespace test._0500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test540
{
    private Solution solution = new();

    [TestMethod]
    public void TestSolution()
    {
        int[] nums = [1, 1, 2, 3, 3, 4, 4, 8, 8];
        Assert.AreEqual(2, solution.SingleNonDuplicate(nums));

        nums = [3, 3, 7, 7, 10, 11, 11];
        Assert.AreEqual(10, solution.SingleNonDuplicate(nums));

        nums = [1, 1, 2, 3, 3];
        Assert.AreEqual(2, solution.SingleNonDuplicate(nums));
    }
}