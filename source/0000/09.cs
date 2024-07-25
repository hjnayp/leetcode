namespace source._0000._09;

/// <summary>
///     https://leetcode.cn/problems/palindrome-number
/// </summary>
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        if (x < 10) return true;
        if (x % 10 == 0) return false;


        int reverseNum = 0;
        while (x > reverseNum)
        {
            int digit = x % 10;
            x /= 10;
            reverseNum = reverseNum * 10 + digit;
        }

        return x == reverseNum || x == reverseNum / 10;
    }
}