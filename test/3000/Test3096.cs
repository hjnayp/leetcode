using JetBrains.Annotations;
using source._3000._3096;

namespace test._3000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3096
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new Solution();
        int[] levels = [1, 0, 1, 0];
        Assert.AreEqual(1, solution.MinimumLevels(levels));
    }

    [TestMethod]
    public void normal_case2()
    {
        Solution solution = new Solution();
        int[] levels = [1, 1, 1, 1, 1];
        Assert.AreEqual(3, solution.MinimumLevels(levels));
    }

    [TestMethod]
    public void impossible_case_1()
    {
        Solution solution = new Solution();
        int[] levels = [0, 0];
        Assert.AreEqual(-1, solution.MinimumLevels(levels));
    }

    [TestMethod]
    public void impossible_case_2()
    {
        Solution solution = new Solution();
        int[] levels = [0, 1];
        Assert.AreEqual(-1, solution.MinimumLevels(levels));
    }

    [TestMethod]
    public void impossible_case_3()
    {
        Solution solution = new Solution();
        int[] levels = [1, 1];
        Assert.AreEqual(-1, solution.MinimumLevels(levels));
    }
}