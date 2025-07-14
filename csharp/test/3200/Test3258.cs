using JetBrains.Annotations;
using source._3200._3258;

namespace test._3200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3258
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        string s = "10101";
        int k = 1;
        Assert.AreEqual(12, solution.CountKConstraintSubstrings(s, k));

        s = "1010101";
        k = 2;
        Assert.AreEqual(25, solution.CountKConstraintSubstrings(s, k));

        s = "11111";
        k = 1;
        Assert.AreEqual(15, solution.CountKConstraintSubstrings(s, k));
    }
}