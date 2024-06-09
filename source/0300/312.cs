namespace source._0300;

public class Solution
{
    public int MaxCoins(int[] nums)
    {
        int n = nums.Length;
        int[,] dp = new int[n + 2, n + 2];
        int[] val = new int[n + 2];
        for (int i = 1; i <= n; ++i) val[i] = nums[i - 1];
        val[0] = val[^1] = 1;

        for (int i = n - 1; i >= 0; --i)
        for (int j = i + 2; j <= n + 1; ++j)
        for (int k = i + 1; k < j; ++k)
            dp[i, j] = Math.Max(dp[i, j], dp[i, k] + dp[k, j] + val[i] * val[k] * val[j]);

        return dp[0, n + 1];
    }
}