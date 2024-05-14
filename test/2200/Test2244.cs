#region

using JetBrains.Annotations;
using source._2200._2244;

#endregion

namespace test._2200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2244
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int[]? tasks = new[] { 2, 2, 3, 3, 2, 4, 4, 4, 4, 4 };
        Assert.AreEqual(4, solution.MinimumRounds(tasks));

        tasks = new[] { 5, 5, 5, 5 };
        Assert.AreEqual(2, solution.MinimumRounds(tasks));
    }

    [TestMethod]
    public void cannot_complete_case()
    {
        var solution = new Solution();
        int[]? tasks = new[] { 2, 3, 3 };
        Assert.AreEqual(-1, solution.MinimumRounds(tasks));
    }
}