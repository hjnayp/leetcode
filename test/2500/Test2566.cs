using JetBrains.Annotations;
using source._2500._2506;

namespace test._2500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2566
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();

        string[] words = ["aba", "aabb", "abcd", "bac", "aabc"];
        int output = 2;
        Assert.AreEqual(output, solution.SimilarPairs(words));

        words = ["aabb", "ab", "ba"];
        output = 3;
        Assert.AreEqual(output, solution.SimilarPairs(words));

        words = ["nba", "cba", "dba"];
        output = 0;
        Assert.AreEqual(output, solution.SimilarPairs(words));
    }
}