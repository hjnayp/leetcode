using JetBrains.Annotations;
using source._2700._2789;

namespace test._2700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2789
{
    [TestMethod]
    public void Method()
    {
        var solution = new Solution();
        int[] input = { 2, 3, 7, 9, 3 };
        long expected = 21;
        long actual = solution.MaxArrayValue(input);
        Assert.AreEqual(expected, actual);

        input = new[] { 5, 3, 3 };
        expected = 11;
        actual = solution.MaxArrayValue(input);
        Assert.AreEqual(expected, actual);
    }
}