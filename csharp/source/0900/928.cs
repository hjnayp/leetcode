namespace source._0900._928;

/// <summary>
///     https://leetcode.cn/problems/minimize-malware-spread-ii
/// </summary>
public class Solution
{
    public int MinMalwareSpread(int[][] graph, int[] initial)
    {
        int n = graph.Length;
        bool[]? initialSet = new bool[n];
        foreach (int v in initial) initialSet[v] = true;
        var infectedBy = new IList<int>[n];
        for (int i = 0; i < n; i++) infectedBy[i] = new List<int>();
        foreach (int v in initial)
        {
            bool[] infectedSet = new bool[n];
            Dfs(infectedSet, v);
            for (int u = 0; u < n; u++)
            {
                if (infectedSet[u])
                {
                    infectedBy[u].Add(v);
                }
            }
        }

        int[] count = new int[n];
        for (int u = 0; u < n; u++)
        {
            if (infectedBy[u].Count == 1)
            {
                count[infectedBy[u][0]]++;
            }
        }

        int res = initial[0];
        foreach (int v in initial)
        {
            if (count[v] > count[res] || (count[v] == count[res] && v < res))
            {
                res = v;
            }
        }

        return res;

        void Dfs(bool[] infectedSet, int v)
        {
            for (int u = 0; u < n; u++)
            {
                if (graph[v][u] == 0 || initialSet[u] || infectedSet[u]) continue;
                infectedSet[u] = true;
                Dfs(infectedSet, u);
            }
        }
    }
}