using JetBrains.Annotations;
using source._2700._2798;

namespace test._2700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2798
{
    [TestMethod]
    public void Normal()
    {
        var solution = new Solution();
        int[] hours = { 0, 1, 2, 3, 4 };
        int target = 2;
        Assert.AreEqual(3, solution.NumberOfEmployeesWhoMetTarget(hours, target));
    }

    [TestMethod]
    public void Normal2()
    {
        var solution = new Solution();
        int[] hours = { 5, 1, 4, 2, 2 };
        int target = 6;
        Assert.AreEqual(0, solution.NumberOfEmployeesWhoMetTarget(hours, target));
    }
}