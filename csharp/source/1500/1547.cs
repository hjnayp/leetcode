namespace source._1500._1547;

/// <summary>
///     <a href="https://leetcode.cn/problems/minimum-cost-to-cut-a-stick">
///         Minimum Cost to Cut a Stick
///     </a>
/// </summary>
public class Solution
{
    public int MinCost(int n, int[] cuts)
    {
        Array.Sort(cuts);

        int m = cuts.Length;
        int[] newCuts = cuts.Append(n).Prepend(0).ToArray();
        int[,] dp = new int[m + 2, m + 2];

        for (int i = m; i >= 1; --i)
        for (int j = i; j <= m; ++j)
        {
            dp[i, j] = i == j ? 0 : int.MaxValue;
            for (int k = i; k <= j; ++k)
            {
                dp[i, j] = Math.Min(dp[i, j], dp[i, k - 1] + dp[k + 1, j]);
            }

            dp[i, j] += newCuts[j + 1] - newCuts[i - 1];
        }

        return dp[1, m];
    }
}