namespace source._0300._304;

public class Solution
{
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        if (n == 1) return new[] { 0 };
        var graph = new Dictionary<int, IList<int>>();
        foreach (int[] edge in edges)
        {
            int a = edge[0];
            int b = edge[1];
            if (!graph.ContainsKey(a))
                graph[a] = new List<int>();
            if (!graph.ContainsKey(b))
                graph[b] = new List<int>();
            graph[a].Add(b);
            graph[b].Add(a);
        }

        int FindLongestNode(int node)
        {
            
        }
        
        
    }

}