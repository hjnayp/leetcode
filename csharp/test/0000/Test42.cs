using JetBrains.Annotations;
using source._0000._42;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test42
{
    [TestMethod, Timeout(1000)]
    public void TestSolution()
    {
        var solution = new Solution();
        int[] height = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1];
        Assert.AreEqual(6, solution.Trap(height));
        Assert.AreEqual(6, solution.Trap(height));

        height = [4, 2, 0, 3, 2, 5];
        Assert.AreEqual(9, solution.Trap(height));
        height = [4, 2, 3];
        Assert.AreEqual(1, solution.Trap(height));
    }
}