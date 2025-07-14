using JetBrains.Annotations;
using source._3200._3261;

namespace test._3200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3261
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        string s = "0001111";
        int k = 2;
        int[][] queries = [[0, 6]];
        long[] result = [26];
        CollectionAssert.AreEqual(result, solution.CountKConstraintSubstrings(s, k, queries));

        s = "010101";
        k = 1;
        queries = [[0, 5], [1, 4], [2, 3]];
        result = [15, 9, 3];
        CollectionAssert.AreEqual(result, solution.CountKConstraintSubstrings(s, k, queries));
    }
}