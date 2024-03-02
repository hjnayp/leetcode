namespace source._2500._2581;

public class Solution
{
    public int RootCount(int[][] edges, int[][] guesses, int k)
    {
        int n = edges.Length + 1;
        var nodes = new List<List<int>>(n);
        for (var i = 0; i < n; ++i)
            nodes.Add(new List<int>());
        foreach (int[] edge in edges)
        {
            int a = edge[0];
            int b = edge[1];
            nodes[a].Add(b);
            nodes[b].Add(a);
        }

        var guessSet = new HashSet<(int, int)>();
        foreach (int[] guess in guesses)
        {
            int a = guess[0];
            int b = guess[1];
            guessSet.Add((a, b));
        }

        var res = 0;
        var correctGuess = 0;

        Dfs(0, -1);
        ReDfs(0, -1, correctGuess);
        return res;

        void Dfs(int node, int from)
        {
            foreach (int i in nodes[node])
            {
                if (i == from)
                    continue;
                correctGuess += guessSet.Contains((node, i)) ? 1 : 0;
                Dfs(i, node);
            }
        }

        void ReDfs(int node, int from, int cnt)
        {
            if (cnt >= k)
                ++res;

            foreach (int i in nodes[node])
            {
                if (i == from)
                    continue;

                int newCnt = cnt;
                if (guessSet.Contains((node, i)))
                    --newCnt;
                if (guessSet.Contains((i, node)))
                    ++newCnt;

                ReDfs(i, node, newCnt);
            }
        }
    }
}