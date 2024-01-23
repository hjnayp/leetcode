using source._0100._162;

namespace test._0100;

[TestClass]
public class Test162
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var input = new[] { 1, 2, 3, 1 };
        var expected = new HashSet<int> { 2 };
        var actual = solution.FindPeakElement(input);
        Assert.IsTrue(expected.Contains(actual));
        expected.Clear();

        input = new[] { 1, 2, 1, 3, 5, 6, 4 };
        expected.Add(1);
        expected.Add(5);
        Assert.IsTrue(expected.Contains(solution.FindPeakElement(input)));
        expected.Clear();

        input = new[] { -2147483648 };
        expected.Add(0);
        Assert.IsTrue(expected.Contains(solution.FindPeakElement(input)));
        expected.Clear();
    }
}