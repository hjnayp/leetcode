namespace source._3000._3067;

public class Solution
{
    public int[] CountPairsOfConnectableServers(int[][] edges, int signalSpeed)
    {
        int n = edges.Length + 1;
        var graph = new List<int[]>[n];
        for (int i = 0; i < n; ++i) graph[i] = new List<int[]>();

        foreach (int[] edge in edges)
        {
            int u = edge[0];
            int v = edge[1];
            int w = edge[2];
            graph[u].Add(new[] { v, w });
            graph[v].Add(new[] { u, w });
        }

        int[] res = new int[n];
        for (int i = 0; i < n; ++i)
        {
            int pre = 0;
            foreach (int[] edge in graph[i])
            {
                int cnt = DFS(edge[0], i, edge[1] % signalSpeed);
                res[i] += cnt * pre;
                pre += cnt;
            }
        }

        return res;

        int DFS(int node, int root, int pathLen)
        {
            int sum = 0;
            if (pathLen == 0) ++sum;
            foreach (int[] edge in graph[node])
            {
                int v = edge[0];
                int cost = edge[1];
                if (v != root) sum += DFS(v, node, (pathLen + cost) % signalSpeed);
            }

            return sum;
        }
    }
}