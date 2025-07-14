using JetBrains.Annotations;
using source._2900._2974;

namespace test._2900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2974
{
    private Solution _solution = new();

    [TestMethod]
    public void normal_case()
    {
        int[] nums = [5, 4, 2, 3];
        int[] expected = [3, 2, 5, 4];
        CollectionAssert.AreEqual(expected, _solution.NumberGame(nums));

        nums = [2, 5];
        expected = [5, 2];
        CollectionAssert.AreEqual(expected, _solution.NumberGame(nums));
    }
}