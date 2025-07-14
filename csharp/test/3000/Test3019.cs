using JetBrains.Annotations;
using source._3000._3019;

namespace test._3000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3019
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        string input = "aAbBcC";
        int expected = 2;
        Assert.AreEqual(expected, solution.CountKeyChanges(input));

        input = "AaAaAaaA";
        expected = 0;
        Assert.AreEqual(expected, solution.CountKeyChanges(input));
    }
}