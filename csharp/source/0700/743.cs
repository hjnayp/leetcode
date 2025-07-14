namespace source._0700;

/// <summary>
///     <a href="https://leetcode.cn/problems/network-delay-time">
///         Network Delay Time
///     </a>
/// </summary>
public class Solution
{
    public int NetworkDelayTime(int[][] times, int n, int k)
    {
        int[,] graph = new int[n, n];
        for (int i = 0; i < n; ++i)
        for (int j = 0; j < n; ++j)
        {
            graph[i, j] = -1;
        }

        foreach (int[] time in times)
        {
            int u = time[0],
                v = time[1],
                w = time[2];

            graph[u - 1, v - 1] = w;
        }

        PriorityQueue<(int, int), int> dist = new();
        dist.Enqueue((k - 1, 0), 0);

        int[] reachedTime = new int[n];
        Array.Fill(reachedTime, int.MaxValue);
        reachedTime[k - 1] = 0;

        while (dist.Count > 0)
        {
            (int u, int w) = dist.Dequeue();
            if (w > reachedTime[u]) continue;

            for (int v = 0; v < n; ++v)
            {
                if (graph[u, v] == -1) continue;

                int distance = w + graph[u, v];
                if (distance >= reachedTime[v]) continue;

                reachedTime[v] = distance;
                dist.Enqueue((v, distance), distance);
            }
        }

        int maxTime = reachedTime.Max();
        return maxTime == int.MaxValue ? -1 : maxTime;
    }
}