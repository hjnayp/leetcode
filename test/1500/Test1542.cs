using JetBrains.Annotations;
using source._1500._1542;

namespace test._1500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1542
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        Assert.AreEqual(5, solution.LongestAwesome("3242415"));
        Assert.AreEqual(1, solution.LongestAwesome("12345678"));
        Assert.AreEqual(6, solution.LongestAwesome("213123"));
    }

    [TestMethod]
    public void cannot_use_all_even_count_number()
    {
        var solution = new Solution();
        Assert.AreEqual(3, solution.LongestAwesome("9498331"));
    }
}