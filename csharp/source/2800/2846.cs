namespace source._2800._2846;

public class Solution
{
    private const int _W = 26;

    public int[] MinOperationsQueries(int n, int[][] edges, int[][] queries)
    {
        int m = queries.Length;
        var neighbors = new IDictionary<int, int>[n];
        for (int i = 0; i < n; i++)
        {
            neighbors[i] = new Dictionary<int, int>();
        }

        foreach (int[] edge in edges)
        {
            neighbors[edge[0]].Add(edge[1], edge[2]);
            neighbors[edge[1]].Add(edge[0], edge[2]);
        }

        var queryArr = new IList<int[]>[n];
        for (int i = 0; i < n; i++)
        {
            queryArr[i] = new List<int[]>();
        }

        for (int i = 0; i < m; i++)
        {
            queryArr[queries[i][0]].Add(new[] { queries[i][1], i });
            queryArr[queries[i][1]].Add(new[] { queries[i][0], i });
        }

        int[][] count = new int[n][];
        for (int i = 0; i < n; i++)
        {
            count[i] = new int[_W + 1];
        }

        bool[] visited = new bool[n];
        int[] uf = new int[n];
        int[] lca = new int[m];
        Tarjan(0, -1, neighbors, queryArr, count, visited, uf, lca);

        int[] res = new int[m];
        for (int i = 0; i < m; i++)
        {
            int totalCount = 0, maxCount = 0;
            for (int j = 1; j <= _W; j++)
            {
                int t = count[queries[i][0]][j] + count[queries[i][1]][j] - 2 * count[lca[i]][j];
                maxCount = Math.Max(maxCount, t);
                totalCount += t;
            }

            res[i] = totalCount - maxCount;
        }

        return res;
    }

    private void Tarjan(int node,
                        int parent,
                        IDictionary<int, int>[] neighbors,
                        IList<int[]>[] queryArr,
                        int[][] count,
                        bool[] visited,
                        int[] uf,
                        int[] lca)
    {
        if (parent != -1)
        {
            Array.Copy(count[parent], 0, count[node], 0, _W + 1);
            count[node][neighbors[node][parent]]++;
        }

        uf[node] = node;
        foreach (int child in neighbors[node].Keys)
        {
            if (child == parent) continue;

            Tarjan(child, node, neighbors, queryArr, count, visited, uf, lca);
            uf[child] = node;
        }

        foreach (int[] pair in queryArr[node])
        {
            int targetNode = pair[0];
            if (node != targetNode && !visited[targetNode]) continue;

            int index = pair[1];
            lca[index] = Find(uf, targetNode);
        }

        visited[node] = true;
    }

    private int Find(int[] uf, int i)
    {
        if (uf[i] == i)
        {
            return i;
        }

        uf[i] = Find(uf, uf[i]);
        return uf[i];
    }
}