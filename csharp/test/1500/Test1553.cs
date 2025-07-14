using JetBrains.Annotations;
using source._1500._1553;

namespace test._1500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1553
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int input = 10;
        int output = 4;
        Assert.AreEqual(output, solution.MinDays(input));

        input = 6;
        output = 3;
        Assert.AreEqual(output, solution.MinDays(input));
    }

    [Timeout(100)]
    [TestMethod]
    public void time_sensitive()
    {
        var solution = new Solution();
        int input = 1122537246;
        int output = 32;
        Assert.AreEqual(output, solution.MinDays(input));
    }
}