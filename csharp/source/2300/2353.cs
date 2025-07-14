namespace source._2300;

/// <summary>
///     <a href="https://leetcode.cn/problems/design-a-food-rating-system">
///         2353. Design a Food Rating System
///     </a>
/// </summary>
public class FoodRatings
{
    private readonly Dictionary<string, SortedSet<(int, string)>> _cuisineToFoods = new();
    private readonly Dictionary<string, (string, int)> _nameToFoodInfo = new();

    public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
    {
        Comparer<(int, string)> comparer = Comparer<(int, string)>.Create((a, b) =>
        {
            int diff = a.Item1.CompareTo(b.Item1);
            return diff != 0
                ? diff
                : string.CompareOrdinal(b.Item2, a.Item2);
        });

        foreach ((string? food, string? cuisine, int rating) in foods.Zip(cuisines, ratings))
        {
            _cuisineToFoods.TryAdd(cuisine, new SortedSet<(int, string)>(comparer));
            _cuisineToFoods[cuisine].Add((rating, food));
            _nameToFoodInfo.Add(food, (cuisine, rating));
        }
    }

    public void ChangeRating(string food, int newRating)
    {
        (string? cuisine, int oldRating) = _nameToFoodInfo[food];
        _cuisineToFoods[cuisine].Remove((oldRating, food));
        _cuisineToFoods[cuisine].Add((newRating, food));
        _nameToFoodInfo[food] = (cuisine, newRating);
    }

    public string HighestRated(string cuisine)
    {
        return _cuisineToFoods[cuisine].Max.Item2;
    }
}