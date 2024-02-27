namespace source._2800._2867;

public class Solution
{
    private const int MaxNum = 100_001;
    private static bool[]? isPrime;

    public long CountPaths(int n, int[][] edges)
    {
        InitPrimes();

        var graph = new List<List<int>>(n + 1);
        for (var i = 0; i <= n; ++i)
            graph.Add(new List<int>());

        foreach (int[] edge in edges)
        {
            int a = edge[0];
            int b = edge[1];
            graph[a].Add(b);
            graph[b].Add(a);
        }

        long res = 0;
        var memo = new int[n + 1];
        Array.Fill(memo, -1);

        for (var i = 1; i <= n; ++i)
        {
            if (!isPrime![i])
                continue;

            var sum = 0;
            foreach (int e in graph[i])
            {
                if (memo[e] < 0)
                    memo[e] = Dfs(e, i);

                res += sum * memo[e];
                sum += memo[e];
            }

            res += sum;
        }

        return res;

        int Dfs(int startNode, int parent)
        {
            if (isPrime![startNode])
                return 0;

            List<int> nextedNode = graph[startNode];
            return 1 + nextedNode.Where(i => i != parent)
                                 .Sum(i => Dfs(i, startNode));
        }
    }

    private static void InitPrimes()
    {
        if (isPrime is not null)
            return;

        isPrime = new bool[MaxNum];
        Array.Fill(isPrime, true);
        isPrime[1] = false;
        for (var i = 2; i * i < MaxNum; i++)
        {
            if (!isPrime[i])
                continue;

            for (long j = i * i; j < MaxNum; j += i)
                isPrime[j] = false;
        }
    }
}