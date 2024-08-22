using JetBrains.Annotations;
using source._3100._3133;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3133
{
    [TestMethod]
    public void NormalCase()
    {
        Solution solution = new();
        Assert.AreEqual(6, solution.MinEnd(3, 4));
        Assert.AreEqual(15, solution.MinEnd(2, 7));
        Assert.AreEqual(55012476815, solution.MinEnd(6715154, 7193485));
    }
}