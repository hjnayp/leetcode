namespace source._2700._2786;

public class Solution
{
    public long MaxScore(int[] nums, int x)
    {
        int n = nums.Length;
        long maxScore = 0;
        long[] dp = { int.MinValue, int.MinValue };
        dp[nums[0] % 2] = nums[0];
        maxScore = Math.Max(dp[0], dp[1]);

        for (int i = 1; i < n; ++i)
        {
            int parity = nums[i] % 2;
            dp[parity] = Math.Max(dp[parity], dp[1 - parity] - x) + nums[i];
            maxScore = Math.Max(maxScore, dp[parity]);
        }

        return maxScore;
    }
}