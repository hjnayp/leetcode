using JetBrains.Annotations;
using source._2900._2928;

namespace test._2900;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2928
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        Assert.AreEqual(3, solution.DistributeCandies(5, 2));
        Assert.AreEqual(10, solution.DistributeCandies(3, 3));
    }
}