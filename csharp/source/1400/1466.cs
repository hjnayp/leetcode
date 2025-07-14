namespace source._1400._1466;

public class Solution
{
    public int MinReorder(int n, int[][] connections)
    {
        var graph = new Dictionary<int, IDictionary<int, bool>>();
        foreach (var connection in connections)
        {
            if (!graph.ContainsKey(connection[0]))
                graph[connection[0]] = new Dictionary<int, bool>();

            if (!graph.ContainsKey(connection[1]))
                graph[connection[1]] = new Dictionary<int, bool>();

            graph[connection[0]][connection[1]] = true;
            graph[connection[1]][connection[0]] = false;
        }


        var res = 0;
        Dfs(0, -1, graph, ref res);
        return res;
    }

    private static void Dfs(int now, int parent, IDictionary<int, IDictionary<int, bool>> graph, ref int res)
    {
        foreach (var child in graph[now])
        {
            if (child.Key == parent) continue;
            if (child.Value)
                ++res;
            Dfs(child.Key, now, graph, ref res);
        }
    }
}