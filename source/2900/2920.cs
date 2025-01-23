namespace source._2900._2920;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximum-points-after-collecting-coins-from-all-nodes">
///         2920. Maximum Points After Collecting Coins From All Nodes
///     </a>
/// </summary>
public class Solution
{
    private const int MAX_DIVIDE_TIME = 14;

    public int MaximumPoints(int[][] edges, int[] coins, int k)
    {
        int[,] memory = new int[coins.Length, MAX_DIVIDE_TIME];
        for (int i = 0; i < coins.Length; ++i)
        for (int j = 0; j < MAX_DIVIDE_TIME; ++j)
        {
            memory[i, j] = -1;
        }

        var graph = new List<int>[coins.Length];
        for (int i = 0; i < coins.Length; ++i)
        {
            graph[i] = [];
        }

        foreach (int[] edge in edges)
        {
            int u = edge[0];
            int v = edge[1];
            graph[u].Add(v);
            graph[v].Add(u);
        }

        return Dfs(0, -1, 0);

        int Dfs(int node, int parent, int divideCount)
        {
            if (memory[node, divideCount] is not -1)
            {
                return memory[node, divideCount];
            }

            int res1 = (coins[node] >> divideCount) - k;
            int res2 = coins[node] >> (divideCount + 1);

            foreach (int e in graph[node])
            {
                if (e == parent) continue;

                res1 += Dfs(e, node, divideCount);
                if (divideCount + 1 < MAX_DIVIDE_TIME)
                {
                    res2 += Dfs(e, node, divideCount + 1);
                }
            }

            return memory[node, divideCount] = Math.Max(res1, res2);
        }
    }
}