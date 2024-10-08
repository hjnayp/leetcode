namespace source._1400._1436;

/// <summary>
///     <a href="https://leetcode.cn/problems/destination-city">
///         Destination City
///     </a>
/// </summary>
public class Solution
{
    public string DestCity(IList<IList<string>> paths)
    {
        HashSet<string> cities = new();
        HashSet<string> visitedCities = new();
        foreach (IList<string> path in paths)
        {
            string from = path[0];
            string to = path[1];
            cities.Add(from);
            cities.Add(to);
            visitedCities.Add(from);
        }

        return cities.First(city => !visitedCities.Contains(city));
    }
}