namespace source._0000._70;

/// <summary>
///     https://leetcode.cn/problems/climbing-stairs/description/
/// </summary>
public class Solution
{
    private static readonly List<int> s_Cache = [0, 1, 2];

    public int ClimbStairs(int n)
    {
        if (n < s_Cache.Count) return s_Cache[n];

        for (int i = s_Cache.Count; i <= n; ++i)
        {
            s_Cache.Add(s_Cache[i - 1] + s_Cache[i - 2]);
        }

        return s_Cache[n];
    }
}