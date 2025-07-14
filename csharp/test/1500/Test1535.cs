using JetBrains.Annotations;
using source._1500._1535;

namespace test._1500;

[TestClass, TestSubject(typeof(Solution))]
public class Test1535
{
    [TestMethod]
    public void normal()
    {
        var solution = new Solution();
        int k = 2;
        int[] arr = { 2, 1, 3, 5, 4, 6, 7 };
        Assert.AreEqual(5, solution.GetWinner(arr, k));

        k = 10;
        arr = new[] { 3, 2, 1 };
        Assert.AreEqual(3, solution.GetWinner(arr, k));
    }
}