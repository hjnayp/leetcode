namespace source._1700._1766;

/// <summary>
///     https://leetcode.cn/problems/tree-of-coprimes
/// </summary>
public class Solution
{
    private static readonly Dictionary<int, List<int>> s_Coprimes = new();

    private static bool IsCoprime(int a, int b)
    {
        return Gcd(a, b) == 1;

        int Gcd(int x, int y)
        {
            while (y != 0)
            {
                int t = x % y;
                x = y;
                y = t;
            }

            return x;
        }
    }

    private static void InitCoprime()
    {
        if (s_Coprimes.Count > 0) return;

        for (var i = 1; i <= 50; ++i)
        {
            s_Coprimes[i] = new List<int>();
            for (var j = 1; j <= 50; ++j)
                if (IsCoprime(i, j))
                    s_Coprimes[i].Add(j);
        }
    }

    private readonly Dictionary<int, List<int>> _graph = new();
    private readonly Dictionary<int, List<int>> _tmps = new();
    private int[]? _ans;
    private int[]? _depths;

    public int[] GetCoprimes(int[] nums, int[][] edges)
    {
        InitCoprime();
        int n = nums.Length;

        _ans = new int[n];
        Array.Fill(_ans, -1);
        _depths = new int[n];
        Array.Fill(_depths, -1);

        for (var i = 0; i < 51; i++)
            _tmps[i] = new List<int>();
        for (var i = 0; i < n; i++)
            _graph[i] = new List<int>();

        foreach (int[] edge in edges)
        {
            int u = edge[0];
            int v = edge[1];

            _graph[u].Add(v);
            _graph[v].Add(u);
        }

        Dfs();

        return _ans.ToArray();

        void Dfs()
        {
            var stack = new Stack<(int idx, int depth)>();
            stack.Push((0, 1));

            while (stack.Count > 0)
            {
                (int idx, int depth) = stack.Peek();
                int num = nums[idx];

                if (_depths[idx] == -1)
                {
                    _depths[idx] = depth;
                    foreach (int val in s_Coprimes[num]
                                        .Where(val => _tmps[val].Count != 0)
                                        .Where(val => _ans[idx] == -1 || _depths[_ans[idx]] < _depths[_tmps[val][^1]]))
                        _ans[idx] = _tmps[val][^1];
                    _tmps[num].Add(idx);
                }

                int[] next = _graph[idx].Where(next => _depths[next] == -1).ToArray();
                if (next.Any())
                {
                    stack.Push((next.First(), depth + 1));
                }
                else
                {
                    stack.Pop();
                    _tmps[num].RemoveAt(_tmps[num].Count - 1);
                }
            }
        }
    }
}