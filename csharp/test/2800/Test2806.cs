using JetBrains.Annotations;
using source._2800._2806;

namespace test._2800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2806
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        Assert.AreEqual(90, solution.AccountBalanceAfterPurchase(10));
        Assert.AreEqual(90, solution.AccountBalanceAfterPurchase(9));
        Assert.AreEqual(80, solution.AccountBalanceAfterPurchase(15));
    }
}