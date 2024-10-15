using JetBrains.Annotations;
using source._3200._3200;

namespace test._3200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3200
{
    [TestMethod, Timeout(1000)]
    public void TestSolution()
    {
        var solution = new Solution();

        Assert.AreEqual(1, solution.MaxHeightOfTriangle(1, 1));
        Assert.AreEqual(3, solution.MaxHeightOfTriangle(2, 4));
        Assert.AreEqual(2, solution.MaxHeightOfTriangle(2, 1));
        Assert.AreEqual(2, solution.MaxHeightOfTriangle(10, 1));
    }
}