namespace source._0600._685;

/// <summary>
///     <a href="https://leetcode.cn/problems/redundant-connection-ii">
///         Redundant Connection II
///     </a>
/// </summary>
public class Solution
{
    private class UnionFind
    {
        private int[] _parent;

        public UnionFind(uint size)
        {
            _parent = new int[size];
            for (int i = 0; i < _parent.Length; i++)
            {
                _parent[i] = i;
            }
        }

        public int Find(int index)
        {
            return index == _parent[index]
                ? _parent[index]
                : _parent[index] = Find(_parent[index]);
        }

        public void Merge(int u, int v)
        {
            _parent[Find(u)] = Find(v);
        }
    }

    public int[] FindRedundantDirectedConnection(int[][] edges)
    {
        int[]? conflict = null;
        int[]? cycle = null;
        int[] parent = new int[edges.Length + 1];
        for (int i = 0; i <= edges.Length; ++i)
        {
            parent[i] = i;
        }

        var unionFind = new UnionFind((uint)edges.Length + 1);

        foreach (int[] edge in edges)
        {
            int from = edge[0];
            int to = edge[1];

            if (to != parent[to])
            {
                conflict = edge;
                continue;
            }

            parent[to] = from;

            if (unionFind.Find(from) == unionFind.Find(to))
            {
                cycle = edge;
            }
            else
            {
                unionFind.Merge(from, to);
            }
        }

        if (conflict is null)
        {
            return cycle;
        }

        if (cycle is null)
        {
            return conflict;
        }

        return
        [
            parent[conflict[1]], conflict[1],
        ];
    }
}