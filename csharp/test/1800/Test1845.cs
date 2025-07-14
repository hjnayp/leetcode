using JetBrains.Annotations;
using source._1800._1845;

namespace test._1800;

[TestClass]
[TestSubject(typeof(SeatManager))]
public class Test1845
{
    [TestMethod]
    public void Test()
    {
        var sm = new SeatManager(10);
        Assert.AreEqual(1, sm.Reserve());
        Assert.AreEqual(2, sm.Reserve());
        sm.Unreserve(1);
        Assert.AreEqual(1, sm.Reserve());
    }
}