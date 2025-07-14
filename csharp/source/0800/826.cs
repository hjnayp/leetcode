namespace source._0800._826;

/// <summary>
///     https://leetcode.cn/problems/most-profit-assigning-work
/// </summary>
public class Solution
{
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
    {
        int difficultyLen = difficulty.Length;

        var jobs = new (int difficulty, int profit)[difficultyLen];
        for (int i = 0; i < difficultyLen; i++) jobs[i] = (difficulty[i], profit[i]);

        Array.Sort(jobs, (a, b) =>
        {
            if (a.profit == b.profit) return b.difficulty - a.difficulty;
            return b.profit - a.profit;
        });
        Array.Sort(worker, (a, b) => b - a);

        int maxProfit = 0;
        int idx = 0;
        foreach (int w in worker)
        {
            while (idx < difficultyLen && w < jobs[idx].difficulty) ++idx;
            if (idx == difficultyLen) break;
            maxProfit += jobs[idx].profit;
        }

        return maxProfit;
    }
}