using JetBrains.Annotations;
using source._2000._2007;

namespace test._2000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2007
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var changed = new[] { 1, 3, 4, 2, 6, 8 };
        var expected = new[] { 1, 3, 4 };
        int[] actual = solution.FindOriginalArray(changed);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void AllZeroCase()
    {
        var solution = new Solution();
        var changed = new[] { 0, 0, 0, 0 };
        var expected = new[] { 0, 0 };
        int[] actual = solution.FindOriginalArray(changed);
        CollectionAssert.AreEqual(expected, actual);
    }
}