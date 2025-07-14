namespace source._3200._3249;

/// <summary>
///     <a href="https://leetcode.cn/problems/count-the-number-of-good-nodes">
///     </a>
/// </summary>
public class Solution
{
    public int CountGoodNodes(int[][] edges)
    {
        Dictionary<int, IList<int>> graph = new();
        foreach (int[] edge in edges)
        {
            int from = edge[0];
            int to = edge[1];

            graph.TryAdd(from, new List<int>());
            graph.TryAdd(to, new List<int>());
            graph[from].Add(to);
            graph[to].Add(from);
        }

        int goodCount = 0;
        CalculateTreeSizeAndTagIsTreeGood(0, -1);
        return goodCount;

        int CalculateTreeSizeAndTagIsTreeGood(int node, int from)
        {
            bool isValid = true;
            int subTreeSize = -1;
            int size = 1;
            foreach (int to in graph[node])
            {
                if (to == from) continue;

                int treeSize = CalculateTreeSizeAndTagIsTreeGood(to, node);
                size += treeSize;
                if (subTreeSize == -1)
                {
                    subTreeSize = treeSize;
                }
                else if (subTreeSize != treeSize)
                {
                    isValid = false;
                }
            }

            if (isValid) goodCount++;

            return size;
        }
    }
}