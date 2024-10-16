namespace source._0000._44;

/// <summary>
///     <a href="https://leetcode.cn/problems/wildcard-matching/">
///         Wildcard Matching
///     </a>
/// </summary>
public class Solution
{
    public bool IsMatch(string s, string p)
    {
        int m = s.Length;
        int n = p.Length;
        bool[,] dp = new bool[m + 1, n + 1];
        dp[0, 0] = true;


        for (int i = 1; i <= n; ++i)
        {
            if (p[i - 1] != '*') break;
            dp[0, i] = true;
        }

        for (int i = 1; i <= m; ++i)
        for (int j = 1; j <= n; ++j)
        {
            dp[i, j] = p[j - 1] switch
            {
                '?' => dp[i - 1, j - 1],
                '*' => dp[i - 1, j] || dp[i, j - 1],
                _ => s[i - 1] == p[j - 1] && dp[i - 1, j - 1],
            };
        }

        return dp[m, n];
    }
}