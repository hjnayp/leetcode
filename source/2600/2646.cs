namespace source._2600._2646;

public class Solution
{
    public int MinimumTotalPrice(int n, int[][] edges, int[] price, int[][] trips)
    {
        IList<IList<int>> graph = new List<IList<int>>();
        for (var i = 0; i < n; ++i)
            graph.Add(new List<int>());

        foreach (var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        var count = new int[n];
        foreach (var trip in trips)
            Dfs(trip[0], -1, trip[1], count, graph);

        var res = Dp(0, -1, count, price, graph);
        return Math.Min(res[0], res[1]);
    }

    private static bool Dfs(int now, int parent, int end, IList<int> count, IList<IList<int>> graph)
    {
        if (now == end)
        {
            ++count[now];
            return true;
        }

        foreach (var child in graph[now])
        {
            if (child == parent) continue;
            if (!Dfs(child, now, end, count, graph)) continue;
            ++count[now];
            return true;
        }

        return false;
    }

    private static int[] Dp(int now, int parent, IList<int> count, IList<int> price, IList<IList<int>> graph)
    {
        var res = new[] { count[now] * price[now], count[now] * price[now] / 2 };
        foreach (var child in graph[now])
        {
            if (child == parent) continue;
            var cost = Dp(child, now, count, price, graph);
            res[0] += Math.Min(cost[0], cost[1]);
            res[1] += cost[0];
        }

        return res;
    }
}