using JetBrains.Annotations;
using source._1400._1436;

namespace test._1400;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1436
{
    [TestMethod]
    [Timeout(1000)]
    public void TestSolution()
    {
        Solution solution = new();

        Assert.AreEqual(
            "Sao Paulo",
            solution.DestCity([["London", "New York"], ["New York", "Lima"], ["Lima", "Sao Paulo"]])
        );
        Assert.AreEqual(
            "A",
            solution.DestCity([["B", "C"], ["D", "B"], ["C", "A"]])
        );
    }
}