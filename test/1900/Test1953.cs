#region

using JetBrains.Annotations;
using source._1900._1953;

#endregion

namespace test._1900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1953
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int[] milestones = new int[] { 1, 2, 3 };
        Assert.AreEqual(6, solution.NumberOfWeeks(milestones));

        milestones = new[] { 9, 3, 6, 8, 2, 1 };
        Assert.AreEqual(29, solution.NumberOfWeeks(milestones));
    }

    [TestMethod]
    public void cannot_finish_all_projects_case()
    {
        var solution = new Solution();
        int[] milestones = new int[] { 5, 2, 1 };
        Assert.AreEqual(7, solution.NumberOfWeeks(milestones));
    }

    [TestMethod]
    public void only_one_project_case()
    {
        var solution = new Solution();
        int[] milestones = new int[] { 1 };
        Assert.AreEqual(1, solution.NumberOfWeeks(milestones));

        milestones = new int[] { 4 };
        Assert.AreEqual(1, solution.NumberOfWeeks(milestones));
    }
}