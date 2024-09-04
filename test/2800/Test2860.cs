using JetBrains.Annotations;
using source._2800._2860;

namespace test._2800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2860
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();
        Assert.AreEqual(2, solution.CountWays([1, 1]));
        Assert.AreEqual(3, solution.CountWays([6,0,3,3,6,7,2,7]));
    }
}