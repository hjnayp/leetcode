namespace source._2400._2477;

public class Solution
{
    private static long Dfs(int current, int parent, int seats, IList<IList<int>> graph, ref long res)
    {
        long people_sum = 1;
        foreach (var child in graph[current])
        {
            if (child == parent) continue;

            var child_people_sum = Dfs(child, current, seats, graph, ref res);
            people_sum += child_people_sum;
            res += (child_people_sum + seats - 1) / seats;
        }

        return people_sum;
    }

    public long MinimumFuelCost(int[][] roads, int seats)
    {
        var n = roads.Length;
        IList<IList<int>> graph = new List<IList<int>>();
        for (var i = 0; i <= n; ++i)
            graph.Add(new List<int>());

        foreach (var road in roads)
        {
            graph[road[0]].Add(road[1]);
            graph[road[1]].Add(road[0]);
        }

        long res = 0;
        Dfs(0, -1, seats, graph, ref res);
        return res;
    }
}