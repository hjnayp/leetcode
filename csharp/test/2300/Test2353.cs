using JetBrains.Annotations;
using source._2300;

namespace test._2300;

[TestClass]
[TestSubject(typeof(FoodRatings))]
public class Test2353
{
    [TestMethod]
    public void TestSolution()
    {
        string[] foods = ["kimchi", "miso", "sushi", "moussaka", "ramen", "bulgogi"];
        string[] cuisines = ["korean", "japanese", "japanese", "greek", "japanese", "korean"];
        int[] ratings = [9, 12, 8, 15, 14, 7];

        string?[] output = ["kimchi", "ramen", null, "sushi", null, "ramen"];
        string[] operations =
        [
            "highestRated", "highestRated", "changeRating", "highestRated", "changeRating",
            "highestRated",
        ];

        object[][] inputs = [["korean"], ["japanese"], ["sushi", 16], ["japanese"], ["ramen", 16], ["japanese"]];

        var foodRating = new FoodRatings(foods, cuisines, ratings);
        for (int i = 1; i < operations.Length; i++)
        {
            string operation = operations[i];
            object[] input = inputs[i];
            string? expected = output[i];
            if (operation is "highestRated")
            {
                Assert.AreEqual(foodRating.HighestRated(input[0] as string), expected);
            }
            else
            {
                foodRating.ChangeRating(input[0] as string, (int)input[1]);
            }
        }
    }

    [TestMethod]
    public void Test2()
    {
        string[] foods = ["b", "a"];
        string[] cuisines = ["1", "1"];
        int[] ratings = [1, 1];
        var foodRating = new FoodRatings(foods, cuisines, ratings);
        string expected = foodRating.HighestRated("1");
        Assert.AreEqual(expected, "a");
    }
}