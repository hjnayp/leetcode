using JetBrains.Annotations;
using source._0000._07;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test07
{
    [TestMethod]
    public void common_positive_input()
    {
        var solution = new Solution();
        Assert.AreEqual(321, solution.Reverse(123));
        Assert.AreEqual(289, solution.Reverse(982));
        Assert.AreEqual(111, solution.Reverse(111));
    }

    [TestMethod]
    public void common_negative_input()
    {
        var solution = new Solution();
        Assert.AreEqual(-321, solution.Reverse(-123));
        Assert.AreEqual(-289, solution.Reverse(-982));
        Assert.AreEqual(-111, solution.Reverse(-111));
    }

    [TestMethod]
    public void input_end_with_0()
    {
        var solution = new Solution();
        Assert.AreEqual(21, solution.Reverse(120));
        Assert.AreEqual(-21, solution.Reverse(-120));
    }

    [TestMethod]
    public void result_over_32int_range()
    {
        var solution = new Solution();
        int x = 1123456789;
        int result = solution.Reverse(x);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void min_int32_value_input()
    {
        var solution = new Solution();
        int x = -2147483648;
        int result = solution.Reverse(x);
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void max_int32_value_input()
    {
        var solution = new Solution();
        int x = 2147483647;
        int result = solution.Reverse(x);
        Assert.AreEqual(0, result);
    }
}