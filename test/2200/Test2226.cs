using JetBrains.Annotations;
using source._2200._2226;

namespace test._2200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2226
{
    [TestMethod]
    [Timeout(2000)]
    public void TestSolution()
    {
        var solution = new Solution();
        int[] candies;
        int k;

        candies =
        [
            750, 253, 391, 342, 151, 655, 934, 601, 870, 338, 866, 798, 806, 795, 580, 225, 225, 961, 506, 536, 620,
            486, 834, 757, 594, 657, 599, 859, 121, 854, 537, 903, 391, 555, 983, 269, 898, 961, 109, 748, 832, 608,
            659, 233, 608, 476, 564, 599, 989, 875, 229, 193, 725, 921, 836, 534, 769, 277, 639, 628, 285, 563, 680,
            839, 403, 689, 489, 979, 529, 868, 514, 795, 941, 464, 340, 700, 997, 792, 422, 645, 745, 637, 908, 701,
            597, 455, 135, 629, 981, 178, 551, 595, 993, 896, 700, 507, 997, 884, 852, 928,
        ];
        k = 46;
        Assert.AreEqual(659, solution.MaximumCandies(candies, k));

        candies = [5, 6, 4, 10, 10, 1, 1, 2, 2, 2];
        k = 9;
        Assert.AreEqual(3, solution.MaximumCandies(candies, k));

        k = 16;
        candies = [4, 7, 5];
        Assert.AreEqual(1, solution.MaximumCandies(candies, k));

        candies = [5, 8, 6];
        k = 3;
        Assert.AreEqual(5, solution.MaximumCandies(candies, k));

        candies = [2, 5];
        k = 11;
        Assert.AreEqual(0, solution.MaximumCandies(candies, k));
    }
}