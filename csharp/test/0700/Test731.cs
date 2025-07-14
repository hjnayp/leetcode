using JetBrains.Annotations;
using source._0700._731;

namespace test._0700;

[TestClass]
[TestSubject(typeof(MyCalendarTwo))]
public class Test731
{
    [TestMethod]
    public void TestSolution()
    {
        var calendar = new MyCalendarTwo();
        Assert.IsTrue(calendar.Book(10, 21));
        Assert.IsTrue(calendar.Book(15, 25));
        Assert.IsFalse(calendar.Book(20, 30));
    }
}