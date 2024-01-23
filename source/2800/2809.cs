namespace source._2800._2809;

public class Solution
{
    public int MinimumTime(IList<int> nums1, IList<int> nums2, int x)
    {
        var n = nums1.Count;
        var indices = new int[n];
        for (var i = 0; i < n; ++i)
            indices[i] = i;

        var dp = new int[n + 1][];
        for (var i = 0; i <= n; ++i)
        {
            dp[i] = new int[n + 1];
            Array.Fill(dp[i], 0);
        }

        Array.Sort(indices, (a, b) => nums2[a] - nums2[b]);
        for (var i = 1; i <= n; ++i)
        {
            for (var j = i; j > 0; --j)
            {
                dp[i][j] = Math.Max(
                    dp[i - 1][j],
                    dp[i - 1][j - 1] + nums1[indices[i - 1]] + nums2[indices[i - 1]] * j
                );
            }
        }

        var sum1 = nums1.Sum(a => (long)a);
        var sum2 = nums2.Sum(a => (long)a);
        for (var i = 0; i <= n; ++i)
            if (sum1 + sum2 * i - dp[n][i] <= x)
                return i;

        return -1;
    }
}