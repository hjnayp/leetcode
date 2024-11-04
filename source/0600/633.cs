namespace source._0600._633;

/// <summary>
///     <a href="https://leetcode.cn/problems/sum-of-square-numbers">
///         Sum of Square Numbers
///     </a>
/// </summary>
public class Solution
{
    public bool JudgeSquareSum(int c)
    {
        int max = (int)Math.Sqrt(c) + 1;
        long left = 0;
        long right = max;
        while (left <= right)
        {
            long sum = left * left + right * right;
            if (c == sum) return true;

            if (sum > c)
            {
                --right;
            }
            else
            {
                ++left;
            }
        }

        return false;
    }
}