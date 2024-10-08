using JetBrains.Annotations;
using source._1200._1227;

namespace test._1200;

[TestClass, TestSubject(typeof(Solution))]
public class Test1227
{
    [TestMethod]
    [Timeout(1000)]
    public void TestSolution()
    {
        Solution solution = new();
        Assert.AreEqual(1.0, solution.NthPersonGetsNthSeat(1));
        Assert.AreEqual(0.5, solution.NthPersonGetsNthSeat(2));
    }
}