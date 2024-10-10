using JetBrains.Annotations;
using source._3100._3162;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3162
{
    [TestMethod, Timeout(1000)]
    public void TestSolution()
    {
        Solution solution = new();
        Assert.AreEqual(5, solution.NumberOfPairs([1, 3, 4], [1, 3, 4], 1));
        Assert.AreEqual(2, solution.NumberOfPairs([1, 2, 4, 12], [2, 4], 3));
        Assert.AreEqual(3, solution.NumberOfPairs([1, 10, 11], [2, 2, 2], 5));
    }
}