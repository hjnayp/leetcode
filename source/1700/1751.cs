namespace source._1700._1751;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximum-number-of-events-that-can-be-attended-ii">
///         1751. Maximum Number of Events That Can Be Attended II
///     </a>
/// </summary>
public class Solution
{
    public int MaxValue(int[][] events, int k)
    {
        Array.Sort(events, (a, b) => a[1].CompareTo(b[1]));

        int[,] dp = new int[events.Length + 1, k + 1];
        for (var i = 0; i < events.Length; i++)
        {
            int p = LowerBound(events, events[i][0]);
            for (int j = 1; j <= k; j++)
            {
                dp[i + 1, j] = Math.Max(dp[i, j], dp[p, j - 1] + events[i][2]);
            }
        }

        return dp[events.Length, k];
    }

    private static int LowerBound(int[][] events, int target)
    {
        int l = 0;
        int r = events.Length;

        while (l < r)
        {
            int mid = l + (r - l) / 2;
            var endDay = events[mid][1];
            if (endDay >= target)
            {
                r = mid;
            }
            else
            {
                l = mid + 1;
            }
        }

        return l;
    }
}