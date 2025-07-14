namespace source._2600._2680;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximum-or">
///         2680. Maximum OR
///     </a>
/// </summary>
public class Solution
{
    public long MaximumOr(int[] nums, int k)
    {
        long orSum = 0;
        long multiBits = 0;
        foreach (var num in nums)
        {
            multiBits |= num & orSum;
            orSum |= num;
        }

        long res = 0;
        foreach (var num in nums)
        {
            res = Math.Max(res, multiBits | (orSum ^ num) | ((long)num << k));
        }

        return res;
    }
}