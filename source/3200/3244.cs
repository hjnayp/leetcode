namespace source._3200._3244;

/// <summary>
///     <a href="https://leetcode.cn/problems/shortest-distance-after-road-addition-queries-ii">
///         Shortest Distance After Road Addition Queries II
///     </a>
/// </summary>
public class Solution
{
    public int[] ShortestDistanceAfterQueries(int n, int[][] queries)
    {
        int[] roads = new int[n];
        for (int i = 0; i < n; i++)
        {
            roads[i] = i + 1;
        }

        int[] res = new int[queries.Length];
        int distance = n - 1;
        for (int i = 0; i < queries.Length; i++)
        {
            int u = queries[i][0];
            int v = queries[i][1];
            int k = roads[u];
            roads[u] = v;

            while (k != -1 && k < v)
            {
                int t = roads[k];
                roads[k] = -1;
                k = t;
                --distance;
            }

            res[i] = distance;
        }

        return res;
    }
}