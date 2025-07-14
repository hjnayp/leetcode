namespace source._1800._1857;

/// <summary>
///     <a href="https://leetcode.cn/problems/largest-color-value-in-a-directed-graph">
///         1857. Largest Color Value in a Directed Graph
///     </a>
/// </summary>
public class Solution
{
    public int LargestPathValue(string colors, int[][] edges)
    {
        Dictionary<int, IList<int>> edgeGraph = new();
        int n = colors.Length;
        int[][] pathColor = new int[n][];
        for (int i = 0; i < n; ++i)
        {
            pathColor[i] = new int [26];
            edgeGraph[i] = new List<int>();
        }

        int[] degrees = new int[n];
        foreach (int[] edge in edges)
        {
            int from = edge[0];
            int to = edge[1];
            edgeGraph[from].Add(to);
            ++degrees[to];
        }

        Queue<int> queue = new();
        for (int i = 0; i < degrees.Length; i++)
        {
            if (degrees[i] == 0)
            {
                queue.Enqueue(i);
            }
        }

        int found = 0;
        while (queue.Count > 0)
        {
            ++found;
            int from = queue.Dequeue();
            ++pathColor[from][colors[from] - 'a'];
            foreach (int to in edgeGraph[from])
            {
                --degrees[to];
                if (degrees[to] is 0)
                {
                    queue.Enqueue(to);
                }

                for (int color = 0; color < 26; color++)
                {
                    pathColor[to][color] = Math.Max(pathColor[to][color], pathColor[from][color]);
                }
            }
        }

        if (found != n)
        {
            return -1;
        }

        return pathColor.Select(colorCount => colorCount.Max()).Prepend(0).Max();
    }
}