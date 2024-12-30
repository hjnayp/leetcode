using JetBrains.Annotations;
using source._3100._3159;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3159
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int[] nums = [1, 3, 1, 7];
        int[] queries = [1, 3, 2, 4];
        int x = 1;
        int[] expected = [0, -1, 2, -1];
        CollectionAssert.AreEqual(expected, solution.OccurrencesOfElement(nums, queries, x));

        nums = [1, 2, 3];
        queries = [10];
        x = 5;
        expected = [-1];
        CollectionAssert.AreEqual(expected, solution.OccurrencesOfElement(nums, queries, x));
    }
}