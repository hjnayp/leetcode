namespace source._0000._05;

/// <summary>
///     https://leetcode.cn/problems/longest-palindromic-substring/
/// </summary>
public class Solution
{
    public string LongestPalindrome(string s)
    {
        int n = s.Length;
        var dp = new bool[n, n];
        for (var i = 0; i < n; i++)
            dp[i, i] = true;

        var maxLen = 1;
        var begin = 0;

        for (var l = 2; l < n; ++l)
        for (var i = 0; i < n; ++i)
        {
            int r = l + i - 1;
            if (r >= n) break;

            char left = s[i];
            char right = s[r];

            if (left == right && (l == 2 || dp[i + 1, r - 1]))
                dp[i, r] = true;

            if (dp[i, r] && l > maxLen)
            {
                maxLen = l;
                begin = i;
            }
        }

        return s.Substring(begin, maxLen);
    }
}