namespace source._0000._05;

/// <summary>
///     https://leetcode.cn/problems/longest-palindromic-substring
/// </summary>
public class Solution
{
    public string LongestPalindrome(string s)
    {
        int n = s.Length;
        bool[,] dp = new bool[n, n];
        for (int i = 0; i < n; i++) dp[i, i] = true;

        int maxLen = 1;
        int begin = 0;

        for (int len = 2; len < n; ++len)
        for (int left = 0; left < n; ++left)
        {
            int right = len + left - 1;
            if (right >= n) break;

            if (IsStringPalindrome(len, left, right, dp, s))
            {
                dp[left, right] = true;
            }

            if (!dp[left, right] || len <= maxLen) continue;

            maxLen = len;
            begin = left;
        }

        return s.Substring(begin, maxLen);
    }

    private static bool IsStringPalindrome(int len, int l, int r, bool[,] dp, string s)
    {
        bool isPrevPalindrome = len == 2 || dp[l + 1, r - 1];
        return isPrevPalindrome && s[l] == s[r];
    }
}