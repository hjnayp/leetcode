using JetBrains.Annotations;
using source._2500._2555;

namespace test._2500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2555
{

    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        int[] prizePositions = [1, 1, 2, 2, 3, 3, 5];
        int k = 2;
        Assert.AreEqual(7, solution.MaximizeWin(prizePositions, k));

        prizePositions = [1, 2, 3, 4];
        k = 0;
        Assert.AreEqual(2, solution.MaximizeWin(prizePositions, k));

        prizePositions = [1, 1, 1, 1, 2, 3, 3, 3];
        k = 2;
        Assert.AreEqual(8, solution.MaximizeWin(prizePositions, k));


    }
}