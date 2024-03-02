namespace source._2300._2368;

public class Solution
{
    public int ReachableNodes(int n, int[][] edges, int[] restricted)
    {
        var graph = new List<List<int>>(n);
        for (var i = 0; i < n; ++i)
            graph.Add(new List<int>());

        var isRestricted = new bool[n];
        foreach (int i in restricted)
            isRestricted[i] = true;

        foreach (int[] edge in edges)
        {
            int a = edge[0];
            int b = edge[1];
            graph[a].Add(b);
            graph[b].Add(a);
        }

        var res = 0;
        Dfs(0, -1);

        return res;

        void Dfs(int startNode, int parent)
        {
            var stack = new Stack<(int, int)>();
            stack.Push((startNode, parent));

            while (stack.Count > 0)
            {
                (int node, int from) = stack.Pop();
                ++res;

                foreach (int i in graph[node].Where(i => !isRestricted[i] && i != from))
                    stack.Push((i, node));
            }
        }
    }
}