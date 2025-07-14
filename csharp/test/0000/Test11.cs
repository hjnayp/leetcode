using JetBrains.Annotations;
using source._0000._11;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test11
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];
        Assert.AreEqual(49, solution.MaxArea(height));
    }
}