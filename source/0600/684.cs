namespace source._0600._684;

/// <summary>
///     <a href="https://leetcode.cn/problems/redundant-connection">
///         684. Redundant Connection
///     </a>
/// </summary>
public class Solution
{
    public int[] FindRedundantConnection(int[][] edges)
    {
        UnionSet scope = new(edges.Length);
        foreach (int[] edge in edges)
        {
            int u = edge[0];
            int v = edge[1];
            if (scope.Find(u - 1) == scope.Find(v - 1)) return edge;

            scope.Merge(u - 1, v - 1);
        }

        return [];
    }

    private class UnionSet
    {
        private readonly int[] parent;

        public UnionSet(int n)
        {
            parent = new int[n];
            for (int i = 0; i < n; ++i)
            {
                parent[i] = i;
            }
        }

        public void Merge(int i, int j)
        {
            int x = Find(i);
            int y = Find(j);
            if (x == y) return;

            parent[x] = y;
        }

        public int Find(int x)
        {
            while (true)
            {
                if (parent[x] == x) return x;
                x = parent[x];
            }
        }
    }
}