using JetBrains.Annotations;
using source._1900._1997;

namespace test._1900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1997
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var nextValues = new[] { 0, 0 };
        Assert.AreEqual(2, solution.FirstDayBeenInAllRooms(nextValues));

        nextValues = new[] { 0, 0, 2 };
        Assert.AreEqual(6, solution.FirstDayBeenInAllRooms(nextValues));

        nextValues = new[] { 0, 1, 2, 0 };
        Assert.AreEqual(6, solution.FirstDayBeenInAllRooms(nextValues));
    }
}