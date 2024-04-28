using JetBrains.Annotations;
using source._1000._1017;

namespace test._1000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1017
{
    [TestMethod]
    public void Normal()
    {
        Test("110", 2);
        Test("111", 3);
        Test("100", 4);
    }

    [TestMethod]
    public void ZeroCase()
    {
        Test("0", 0);
    }

    private void Test(string expected, int n)
    {
        var solution = new Solution();
        Assert.AreEqual(expected, solution.BaseNeg2(n));
    }
}