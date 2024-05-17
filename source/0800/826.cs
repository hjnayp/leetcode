namespace source._0800._826;

public class Solution
{
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
    {
        Array.Sort(worker, (a, b) => b - a);
        int n = difficulty.Length;
        var jobs = new (int difficulty, int profit)[n];
        for (int i = 0; i < n; i++)
        {
            jobs[i] = (difficulty[i], profit[i]);
        }

        Array.Sort(jobs, (a, b) =>
        {
            if (a.profit == b.profit) return b.difficulty - a.difficulty;
            return b.profit - a.profit;
        });

        int res = 0;
        int idx = 0;
        foreach (int w in worker)
        {
            while (idx < n && w < jobs[idx].difficulty)
            {
                ++idx;
            }

            if (idx == n) break;
            res += jobs[idx].profit;
        }

        return res;
    }
}