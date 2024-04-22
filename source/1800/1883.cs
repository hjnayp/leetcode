namespace source._1800._1883;

public class Solution
{
    public int MinSkips(int[] dist, int speed, int hoursBefore)
    {
        const double EXP = 10e-8;
        int n = dist.Length;

        var dp = new double[n + 1, n + 1];
        for (var i = 0; i <= n; i++)
        for (var j = 0; j <= n; j++)
            dp[i, j] = int.MaxValue;

        dp[0, 0] = 0;
        for (var i = 1; i <= n; ++i)
        for (var j = 0; j <= i; ++j)
        {
            if (j != i)
                dp[i, j] = Math.Min(dp[i, j], Math.Ceiling(dp[i - 1, j] + dist[i - 1] * 1.0 / speed - EXP));

            if (j != 0)
                dp[i, j] = Math.Min(dp[i, j], dp[i - 1, j - 1] + dist[i - 1] * 1.0 / speed);
        }

        for (var i = 0; i <= n; i++)
            if (dp[n, i] < hoursBefore + EXP)
                return i;

        return -1;
    }
}