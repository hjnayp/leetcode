namespace source._3300._3372;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximize-the-number-of-target-nodes-after-connecting-trees-i">
///         3372. Maximize the Number of Target Nodes After Connecting Trees I
///     </a>
/// </summary>
public class Solution
{
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2, int k)
    {
        int n = edges1.Length + 1;
        int[] count1 = Build(edges1, k);
        int[] count2 = Build(edges2, k - 1);
        int maxCount2 = count2.Prepend(0).Max();

        int[] res = new int[n];
        for (int i = 0; i < n; i++)
        {
            res[i] = count1[i] + maxCount2;
        }

        return res;
    }

    private int[] Build(int[][] edges, int k)
    {
        int n = edges.Length + 1;
        var children = new List<List<int>>();
        for (int i = 0; i < n; i++)
        {
            children.Add(new List<int>());
        }

        foreach (int[] edge in edges)
        {
            children[edge[0]].Add(edge[1]);
            children[edge[1]].Add(edge[0]);
        }

        int[] res = new int[n];
        for (int i = 0; i < n; i++)
        {
            res[i] = Dfs(i, -1, children, k);
        }

        return res;
    }

    private int Dfs(int node, int parent, List<List<int>> children, int k)
    {
        if (k < 0)
        {
            return 0;
        }

        int targetNodes = children[node].Where(child => child != parent)
            .Sum(child => Dfs(child, node, children, k - 1));

        return targetNodes + 1;
    }
}