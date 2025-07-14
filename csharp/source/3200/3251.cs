namespace source._3200._3251;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-the-count-of-monotonic-pairs-ii">
///         3251. Find the Count of Monotonic Pairs II
///     </a>
/// </summary>
public class Solution
{
    private const int MOD = 1000000007;

    public int CountOfPairs(int[] nums)
    {
        int n = nums.Length;
        int maxValue = nums.Max();

        int[,] dp = new int[n, maxValue + 1];
        for (int i = 0; i <= nums[0]; ++i)
        {
            dp[0, i] = 1;
        }

        for (int i = 1; i < nums.Length; ++i)
        {
            int d = Math.Max(0, nums[i] - nums[i - 1]);
            for (int j = 0; j < nums[i]; ++j)
            {
                dp[i, j] = dp[i - 1, j - d];

                if (j > 0)
                {
                    dp[i, j] = (dp[i, j] + dp[i, j - 1]) % MOD;
                }
            }
        }

        int res = 0;
        for (int i = 0; i <= maxValue; ++i)
        {
            res = (res + dp[n - 1, i]) % MOD;
        }

        return res;
    }
}