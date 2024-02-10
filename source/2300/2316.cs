namespace source._2300._2316;

public class Solution
{
    private List<List<int>> _graph = new();

    public long CountPairs(int n, int[][] edges)
    {
        for (var i = 0; i < n; ++i)
            _graph.Add(new List<int>());

        foreach (int[] edge in edges)
        {
            int a = edge[0];
            int b = edge[1];
            _graph[a].Add(b);
            _graph[b].Add(a);
        }

        return DivideGroup(n);
    }

    public long DivideGroup(int n)
    {
        var visited = new bool[n];
        var res = 0L;
        var nodeSum = 0L;
        for (var i = 0; i < n; ++i)
        {
            if (visited[i])
                continue;

            var group = new List<int>();
            Dfs(i, visited, group);
            int m = group.Count;
            res += m * nodeSum;
            nodeSum += m;
        }

        return res;
    }

    private void Dfs(int node, bool[] visited, List<int> group)
    {
        if (visited[node])
            return;

        group.Add(node);
        visited[node] = true;
        _graph[node].ForEach(v => { Dfs(v, visited, group); });
    }
}