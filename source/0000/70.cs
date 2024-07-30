namespace source._0000._70;

/// <summary>
///     https://leetcode.cn/problems/climbing-stairs/description/
/// </summary>
public class Solution
{
    private static readonly List<int> Cache = [0, 1, 2];

    public int ClimbStairs(int n)
    {
        if (n < Cache.Count)
        {
            return Cache[n];
        }

        for (int i = Cache.Count; i <= n; ++i)
        {
            Cache.Add(Cache[i - 1] + Cache[i - 2]);
        }

        return Cache[n];
    }
}