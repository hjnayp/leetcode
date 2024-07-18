namespace source._3100._3112;

public class Solution
{
    public int[] MinimumTime(int n, int[][] edges, int[] disappear)
    {
        IDictionary<int, IList<(int, int)>> graph = new Dictionary<int, IList<(int, int)>>();
        for (int i = 0; i < n; ++i) graph.TryAdd(i, new List<(int, int)>());
        foreach (int[] edge in edges)
        {
            int u = edge[0];
            int v = edge[1];
            int w = edge[2];
            graph[v].Add((u, w));
            graph[u].Add((v, w));
        }

        int[] minReachTime = new int[n];
        Array.Fill(minReachTime, -1);
        minReachTime[0] = 0;

        var waitSearchNodes = new PriorityQueue<(int, int), int>();
        waitSearchNodes.Enqueue((0, 0), 0);
        while (waitSearchNodes.Count > 0)
        {
            (int node, int time) = waitSearchNodes.Dequeue();
            if (time != minReachTime[node]) continue;
            foreach ((int nextNode, int weight) in graph[node])
            {
                int nextTime = time + weight;
                if (nextTime >= disappear[nextNode] ||
                    (minReachTime[nextNode] != -1 && nextTime >= minReachTime[nextNode]))
                {
                    continue;
                }

                minReachTime[nextNode] = nextTime;
                waitSearchNodes.Enqueue((nextNode, nextTime), nextTime);
            }
        }

        return minReachTime;
    }
}