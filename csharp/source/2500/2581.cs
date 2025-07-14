namespace source._2500._2581;

public class Solution
{
    public int RootCount(int[][] edges, int[][] guesses, int k)
    {
        IDictionary<int, IList<int>> graph = new Dictionary<int, IList<int>>();
        foreach (int[] edge in edges)
        {
            int u = edge[0];
            int v = edge[1];
            graph.TryAdd(u, new List<int>());
            graph.TryAdd(v, new List<int>());
            graph[u].Add(v);
            graph[v].Add(u);
        }

        ISet<(int, int)> guessEdges = new HashSet<(int, int)>();
        foreach (int[] guess in guesses) guessEdges.Add((guess[0], guess[1]));

        int correctGuessCount = 0;
        int validRootCount = 0;
        Dfs(0, -1);
        ReDfs(0, -1, correctGuessCount);
        return validRootCount;

        void Dfs(int node, int parentNode)
        {
            foreach (int neighborNode in graph[node])
            {
                if (neighborNode == parentNode) continue;
                if (guessEdges.Contains((node, neighborNode))) ++correctGuessCount;
                Dfs(neighborNode, node);
            }
        }

        void ReDfs(int node, int parentNode, int nowCorrectGuessCnt)
        {
            if (nowCorrectGuessCnt >= k) ++validRootCount;
            foreach (int neighborNode in graph[node])
            {
                if (neighborNode == parentNode) continue;
                int correctGuessChangeCnt = (guessEdges.Contains((neighborNode, node)) ? 1 : 0) -
                    (guessEdges.Contains((node, neighborNode)) ? 1 : 0);
                ReDfs(neighborNode, node, nowCorrectGuessCnt + correctGuessChangeCnt);
            }
        }
    }
}