using JetBrains.Annotations;
using Solution1 = source._2500._2589.Solution1.Solution;
using Solution2 = source._2500._2589.Solution2.Solution;
using Solution3 = source._2500._2589.Solution3.Solution;

namespace test._2500;

[TestClass]
[TestSubject(typeof(Solution1))]
public class Test2589
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution1();
        int[][] tasks =
        {
            new[] { 2, 3, 1 },
            new[] { 4, 5, 1 },
            new[] { 1, 5, 2 }
        };

        Assert.AreEqual(2, solution.FindMinimumTime(tasks));

        tasks = new[]
        {
            new[] { 1, 3, 2 },
            new[] { 2, 5, 3 },
            new[] { 5, 6, 2 }
        };
        Assert.AreEqual(4, solution.FindMinimumTime(tasks));
    }
}

[TestClass]
[TestSubject(typeof(Solution2))]
public class Test2589Solution2
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution2();
        int[][] tasks =
        {
            new[] { 2, 3, 1 },
            new[] { 4, 5, 1 },
            new[] { 1, 5, 2 }
        };
        Assert.AreEqual(2, solution.FindMinimumTime(tasks));

        tasks = new[]
        {
            new[] { 1, 3, 2 },
            new[] { 2, 5, 3 },
            new[] { 5, 6, 2 }
        };
        Assert.AreEqual(4, solution.FindMinimumTime(tasks));
    }
}

[TestClass]
[TestSubject(typeof(Solution3))]
public class Test2589Solution3
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution3();
        int[][] tasks =
        {
            new[] { 2, 3, 1 },
            new[] { 4, 5, 1 },
            new[] { 1, 5, 2 }
        };
        Assert.AreEqual(2, solution.FindMinimumTime(tasks));

        tasks = new[]
        {
            new[] { 1, 3, 2 },
            new[] { 2, 5, 3 },
            new[] { 5, 6, 2 }
        };
        Assert.AreEqual(4, solution.FindMinimumTime(tasks));
    }
}