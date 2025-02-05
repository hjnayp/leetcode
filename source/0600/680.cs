namespace source._0600._680;

/// <summary>
///     <a href="https://leetcode.cn/problems/valid-palindrome-ii">
///         680. Valid Palindrome II
///     </a>
/// </summary>
public class Solution
{
    public bool ValidPalindrome(string s)
    {
        int len = s.Length;
        int left = 0;
        int right = len - 1;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                return IsPalindrome(s, left + 1, right)
                    || IsPalindrome(s, left, right - 1);
            }

            ++left;
            --right;
        }

        return true;
    }

    private bool IsPalindrome(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }

            ++left;
            --right;
        }

        return true;
    }
}