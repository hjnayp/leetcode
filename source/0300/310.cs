namespace source._0300._310;

public class Solution
{
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        var res = new List<int>();
        if (n == 1)
        {
            res.Add(0);
            return res;
        }

        var graph = new List<List<int>>(n);
        for (var i = 0; i < n; i++)
            graph.Add(new List<int>());

        foreach (int[] edge in edges)
        {
            int a = edge[0];
            int b = edge[1];
            graph[a].Add(b);
            graph[b].Add(a);
        }

        var parent = new int[n];
        Array.Fill(parent, -1);
        int x = FindLongestNode(0);
        int y = FindLongestNode(x);
        var path = new List<int>();
        parent[x] = -1;
        while (y != -1)
        {
            path.Add(y);
            y = parent[y];
        }

        int m = path.Count;
        if (m % 2 == 0)
            res.Add(path[m / 2 - 1]);
        res.Add(path[m / 2]);
        return res;

        int FindLongestNode(int node)
        {
            var visited = new bool[n];
            Array.Fill(visited, false);
            visited[node] = true;

            var queue = new Queue<int>();
            queue.Enqueue(node);
            int res = -1;
            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                res = current;
                foreach (int i in graph[current])
                {
                    if (visited[i]) continue;
                    visited[i] = true;
                    parent[i] = current;
                    queue.Enqueue(i);
                }
            }

            return res;
        }
    }
}