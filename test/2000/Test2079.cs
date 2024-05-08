using JetBrains.Annotations;
using source._2000._2079;

namespace test._2000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2079
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int[] plants = { 2, 2, 3, 3 };
        int capacity = 5;
        Assert.AreEqual(14, solution.WateringPlants(plants, capacity));

        plants = new[] { 1, 1, 1, 4, 2, 3 };
        capacity = 4;
        Assert.AreEqual(30, solution.WateringPlants(plants, capacity));

        plants = new[] { 7, 7, 7, 7, 7, 7, 7 };
        capacity = 8;
        Assert.AreEqual(49, solution.WateringPlants(plants, capacity));
    }
}