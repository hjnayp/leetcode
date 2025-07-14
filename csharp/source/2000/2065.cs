namespace source._2000._2065;

using PathNode = (int, int);

public class Solution
{
    public int MaximalPathQuality(int[] values, int[][] edges, int maxTime)
    {
        IDictionary<int, IList<PathNode>> graph = new Dictionary<int, IList<PathNode>>();
        foreach (int[] edge in edges)
        {
            int u = edge[0];
            int v = edge[1];
            int w = edge[2];
            graph.TryAdd(u, new List<PathNode>());
            graph.TryAdd(v, new List<PathNode>());
            graph[u].Add((v, w));
            graph[v].Add((u, w));
        }

        int maxQuality = 0;
        int nowCostTime = 0;
        IList<int> path = new List<int>() { 0 };

        Dfs(0, -1);
        return maxQuality;

        void Dfs(int node, int fromNode)
        {
            if (node == 0) UpdateMaxQuality();
            if (!graph.TryGetValue(node, out IList<PathNode>? nextNodes)) return;

            foreach ((int to, int time) in nextNodes)
            {
                if (nowCostTime + time > maxTime) continue;

                nowCostTime += time;
                path.Add(to);
                Dfs(to, node);
                nowCostTime -= time;
                path.RemoveAt(path.Count - 1);
            }
        }

        void UpdateMaxQuality()
        {
            ISet<int> uniquePathNodes = new HashSet<int>();
            int sum = path.Sum((node) => !uniquePathNodes.Add(node) ? 0 : values[node]);
            maxQuality = Math.Max(maxQuality, sum);
        }
    }
}