using source._3200._3254;

namespace test._3200;

[TestClass]
public class Test3254
{
    [TestMethod]
    [Timeout(2000)]
    public void TestResultsArray()
    {
        Solution solution = new Solution();

        int[] output = [];
        CollectionAssert.AreEqual(output, solution.ResultsArray([], 0));

        output = [1];
        CollectionAssert.AreEqual(output, solution.ResultsArray([1], 1));

        output = [-1, 3, -1, 3, -1];
        CollectionAssert.AreEqual(output, solution.ResultsArray([3, 2, 3, 2, 3, 2], 2));

        output = [1, 2, 3, 4, 5];
        CollectionAssert.AreEqual(output, solution.ResultsArray(new int[] { 1, 2, 3, 4, 5 }, 1));

        output = [2, 3, 4, 5];
        CollectionAssert.AreEqual(output, solution.ResultsArray(new int[] { 1, 2, 3, 4, 5 }, 2));

        output = [3, -1, -1];
        CollectionAssert.AreEqual(output, solution.ResultsArray(new int[] { 1, 2, 3, 2, 5 }, 3));

        output = [-1, -1, -1, -1];
        CollectionAssert.AreEqual(output, solution.ResultsArray(new int[] { 2, 2, 2, 2, 2 }, 2));
    }
}