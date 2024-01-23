using source._2400._2454;

namespace test._2400;

[TestClass]
public class Test2454
{
    [TestMethod]
    [Timeout(1500)]
    public void NormalCase()
    {
        var solution = new Solution();
        var nums = new[] { 2, 4, 0, 9, 6 };
        var expected = new[] { 9, 6, 6, -1, -1 };
        CollectionAssert.AreEqual(expected, solution.SecondGreaterElement(nums));

        nums = new[] { 3, 3 };
        expected = new[] { -1, -1 };
        CollectionAssert.AreEqual(expected, solution.SecondGreaterElement(nums));
    }
}