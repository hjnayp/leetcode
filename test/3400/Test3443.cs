using JetBrains.Annotations;
using source._3400._3443;

namespace test._3400;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3443
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();
        string s = "";
        int k = 0;
        int expected = 0;

        s = "NWSE";
        k = 1;
        expected = 3;
        Assert.AreEqual(expected, solution.MaxDistance(s, k));
    }
}