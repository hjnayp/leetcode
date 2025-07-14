using JetBrains.Annotations;
using source._3100._3175;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3175
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();

        int[] skills = [4, 2, 6, 3, 9];
        int k = 2;

        Assert.AreEqual(2, solution.FindWinningPlayer(skills, k));

        skills = [2, 5, 4];
        k = 3;
        Assert.AreEqual(1, solution.FindWinningPlayer(skills, k));

        skills = [1, 6, 17];
        k = 1;
        Assert.AreEqual(1, solution.FindWinningPlayer(skills, k));
    }
}