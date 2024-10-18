using JetBrains.Annotations;
using source._3100._3193;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3193
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();

        int[][] requirements = [[2, 2], [0, 0]];
        int n = 3;
        Assert.AreEqual(2, solution.NumberOfPermutations(n, requirements));

        requirements = [[2, 2], [1, 1], [0, 0]];
        n = 3;
        Assert.AreEqual(1, solution.NumberOfPermutations(n, requirements));

        requirements = [[0, 0], [1, 0]];
        n = 2;
        Assert.AreEqual(1, solution.NumberOfPermutations(n, requirements));
    }
}