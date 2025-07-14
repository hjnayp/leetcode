using JetBrains.Annotations;
using source._2100._2105;

namespace test._2100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2105
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        int[] plants = { 2, 2, 3, 3 };
        int capacityA = 5;
        int capacityB = 5;
        Assert.AreEqual(1, solution.MinimumRefill(plants, capacityA, capacityB));

        capacityA = 3;
        capacityB = 4;
        Assert.AreEqual(2, solution.MinimumRefill(plants, capacityA, capacityB));

        plants = new[] { 2, 1, 1 };
        capacityA = 2;
        capacityB = 2;
        Assert.AreEqual(0, solution.MinimumRefill(plants, capacityA, capacityB));

        plants = new[]
        {
            726, 739, 934, 116, 643, 648, 473, 984, 482, 85, 850, 806, 146, 764, 156, 66, 186, 339, 985, 237, 662, 552,
            800, 78, 617, 933, 481, 652, 796, 594, 151, 82, 183, 241, 525, 221, 951, 732, 799, 483, 368, 354, 776, 175,
            974, 187, 913, 842
        };
        capacityA = 1439;
        capacityB = 1207;
        Assert.AreEqual(24, solution.MinimumRefill(plants, capacityA, capacityB));
    }

    [TestMethod]
    public void zero_move()
    {
        var solution = new Solution();
        int[] plants = { 5 };
        int capacityA = 10;
        int capacityB = 8;
        Assert.AreEqual(0, solution.MinimumRefill(plants, capacityA, capacityB));
    }
}