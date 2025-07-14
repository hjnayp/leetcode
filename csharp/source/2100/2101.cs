namespace source._2100._2101;

public class Solution
{
    public int MaximumDetonation(int[][] bombs)
    {
        IDictionary<int, IList<int>> graph = new Dictionary<int, IList<int>>();
        for (int i = 0; i < bombs.Length; ++i) graph.Add(i, new List<int>());

        for (int i = 0; i < bombs.Length; i++)
        for (int j = i + 1; j < bombs.Length; j++)
        {
            if (IsBombDetonateTarget(bombs[i], bombs[j])) graph[i].Add(j);
            if (IsBombDetonateTarget(bombs[j], bombs[i])) graph[j].Add(i);
        }

        int maxDetonateCnt = 1;
        bool[] visited = new bool[bombs.Length];

        for (int i = 0; i < bombs.Length; i++)
        {
            Array.Fill(visited, false);
            maxDetonateCnt = Math.Max(maxDetonateCnt, Dfs(i));
        }

        return maxDetonateCnt;

        int Dfs(int node)
        {
            visited[node] = true;
            int nodeCnt = 1;

            foreach (int nextNode in graph[node])
            {
                if (visited[nextNode]) continue;
                nodeCnt += Dfs(nextNode);
            }

            return nodeCnt;
        }

        bool IsBombDetonateTarget(int[] bomb, int[] target)
        {
            return bomb[2] >= Math.Sqrt(Math.Pow(bomb[0] - target[0], 2) + Math.Pow(bomb[1] - target[1], 2));
        }
    }
}