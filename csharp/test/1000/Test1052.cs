using JetBrains.Annotations;
using source._1000._1052;

namespace test._1000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1052
{
    [TestMethod]
    public void Normal()
    {
        var solution = new Solution();
        int[] customers = { 1, 0, 1, 2, 1, 1, 7, 5 };
        int[] grumpy = { 0, 1, 0, 1, 0, 1, 0, 1 };
        var minutes = 3;
        var expected = 16;
        Assert.AreEqual(expected, solution.MaxSatisfied(customers, grumpy, minutes));
    }

    [TestMethod]
    public void Normal2()
    {
        var solution = new Solution();
        int[] customers = { 1 };
        int[] grumpy = { 0 };
        var minutes = 1;
        var expected = 1;
        Assert.AreEqual(expected, solution.MaxSatisfied(customers, grumpy, minutes));
    }

    [TestMethod]
    public void Normal3()
    {
        var solution = new Solution();
        int[] customers = { 10, 1, 7 };
        int[] grumpy = { 0, 0, 0 };
        var minutes = 2;
        var expected = 18;
        Assert.AreEqual(expected, solution.MaxSatisfied(customers, grumpy, minutes));
    }
}