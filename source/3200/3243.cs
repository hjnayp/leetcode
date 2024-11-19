namespace source._3200._3243;

/// <summary>
///     <a href="https://leetcode.cn/problems/shortest-distance-after-road-addition-queries-i">
///         Shortest Distance After Road Addition Queries I
///     </a>
/// </summary>
public class Solution
{
    public int[] ShortestDistanceAfterQueries(int n, int[][] queries)
    {
        int[,] distance = new int[n, n];

        for (int i = 0; i < n; ++i)
        for (int j = i + 1; j < n; ++j)
        {
            distance[i, j] = j - i;
        }

        List<int> res = [];
        foreach (int[] query in queries)
        {
            int u = query[0];
            int v = query[1];
            distance[u, v] = 1;

            for (int i = u; i >= 0; --i)
            for (int j = v; j < n; ++j)
            {
                distance[i, j] = Math.Min(distance[i, j], distance[i, u] + distance[v, j] + 1);
            }

            res.Add(distance[0, n - 1]);
        }

        return res.ToArray();
    }
}