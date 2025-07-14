using JetBrains.Annotations;
using source._1100._1103;

namespace test._1100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1103
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        CollectionAssert.AreEquivalent(new[] { 5, 2, 3 }, solution.DistributeCandies(10, 3));
        CollectionAssert.AreEquivalent(new[] { 1, 2, 3, 1 }, solution.DistributeCandies(7, 4));
    }
}