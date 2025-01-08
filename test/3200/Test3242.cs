using JetBrains.Annotations;
using source._3200._3242;

namespace test._3200;

[TestClass]
[TestSubject(typeof(NeighborSum))]
public class Test3242
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new NeighborSum([[0, 1, 2], [3, 4, 5], [6, 7, 8]]);
        Assert.AreEqual(6, solution.AdjacentSum(1));
        Assert.AreEqual(16, solution.AdjacentSum(4));
        Assert.AreEqual(16, solution.DiagonalSum(4));
        Assert.AreEqual(4, solution.DiagonalSum(8));
    }
}