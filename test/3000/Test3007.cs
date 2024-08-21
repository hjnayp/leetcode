using JetBrains.Annotations;
using source._3000._3007;

namespace test._3000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3007
{
    [TestMethod]
    public void NormalCase()
    {
        Solution solution = new();

        Assert.AreEqual(6, solution.FindMaximumNumber(9, 1));
        Assert.AreEqual(9, solution.FindMaximumNumber(7, 2));
    }
}