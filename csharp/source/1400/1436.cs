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
        HashSet<string> cities = paths.Select(p => p[0]).ToHashSet();
        return paths.FirstOrDefault(p => !cities.Contains(p[1]), ["", ""])[1];
    }
}