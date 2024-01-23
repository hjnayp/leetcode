namespace source._0700._746;

public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        var dp = new int[cost.Length + 1];
        dp[0] = 0;
        dp[1] = 0;

        for (var i = 2; i <= cost.Length; ++i)
            dp[i] = Math.Min(dp[i - 2] + cost[i - 2], dp[i - 1] + cost[i - 1]);

        return dp[^1];
    }
}