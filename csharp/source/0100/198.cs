namespace source._0100._198;

/// <summary>
///     <a href="https://leetcode.cn/problems/house-robber">
///         House Robber
///     </a>
/// </summary>
public class Solution
{
    public int Rob(int[] nums)
    {
        int[,] dp = new int[nums.Length, 2];
        dp[0, 0] = 0;
        dp[0, 1] = nums[0];
        for (int i = 1; i < nums.Length; ++i)
        {
            dp[i, 0] = Math.Max(dp[i - 1, 1], dp[i - 1, 0]);
            dp[i, 1] = dp[i - 1, 0] + nums[i];
        }

        return Math.Max(dp[nums.Length - 1, 0], dp[nums.Length - 1, 1]);
    }
}