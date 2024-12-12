namespace source._2900._2931;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximum-spending-after-buying-items">
///         2931. Maximum Spending After Buying Items
///     </a>
/// </summary>
public class Solution
{
    public long MaxSpending(int[][] values)
    {
        PriorityQueue<(int, int, int), int> maxValues = new();

        for (int i = 0; i < values.Length; i++)
        {
            maxValues.Enqueue((i, 0, values[i][0]), -values[i][0]);
        }

        int n = values[0].Length;
        int m = values.Length;
        int k = m * n;
        long cost = 0;
        for (int i = 0; i < k; ++i)
        {
            (int idx, int order, int value) = maxValues.Dequeue();
            cost += value * 1L * (k - i);
            if (order == n - 1) continue;

            maxValues.Enqueue((idx, order + 1, values[idx][order + 1]), -values[idx][order + 1]);
        }

        return cost;
    }
}