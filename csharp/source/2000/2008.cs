namespace source._2000._2008;

public class Solution
{
    public long MaxTaxiEarnings(int n, int[][] rides)
    {
        var ride_map = new Dictionary<int, List<int[]>>();
        foreach (var ride in rides)
        {
            var end = ride[1];
            if (!ride_map.ContainsKey(end))
                ride_map[end] = new List<int[]>();
            ride_map[end].Add(ride);
        }

        var dp = new long[n + 1];
        dp[0] = 0;
        for (var i = 1; i <= n; ++i)
        {
            dp[i] = dp[i - 1];
            if (!ride_map.TryGetValue(i, out var ride_list)) continue;
            foreach (var ride in ride_list)
            {
                var start = ride[0];
                var tip = ride[1] - start + ride[2];
                dp[i] = Math.Max(dp[i], dp[start] + tip);
            }
        }

        return dp[n];
    }
}