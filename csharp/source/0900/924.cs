namespace source._0900._924;

/// <summary>
///     https://leetcode.cn/problems/minimize-malware-spread
/// </summary>
public class Solution
{
    private class Tree
    {
        public readonly List<int> Nodes = new();
        public readonly List<int> InitialNodes = new();
    }

    public int MinMalwareSpread(int[][] graph, int[] initial)
    {
        int n = graph.Length;
        var visited = new bool[n];
        var trees = new List<Tree>();
        Array.Sort(initial, (a, b) => a - b);
        foreach (int i in initial)
        {
            if (visited[i]) continue;
            Bfs(i);
        }

        trees.Sort((a, b) => a.InitialNodes.Count == b.InitialNodes.Count
                       ? b.Nodes.Count - a.Nodes.Count
                       : a.InitialNodes.Count - b.InitialNodes.Count);

        foreach (Tree tree in trees.Where(tree => tree.InitialNodes.Count != 0))
        {
            if (tree.InitialNodes.Count == 1)
                return tree.InitialNodes[0];
            break;
        }

        return initial[0];


        void Bfs(int startNode)
        {
            var nodes = new Queue<int>();
            var tree = new Tree();
            nodes.Enqueue(startNode);
            tree.InitialNodes.Add(startNode);
            tree.Nodes.Add(startNode);
            while (nodes.Any())
            {
                int node = nodes.Dequeue();
                if (visited[node]) continue;
                visited[node] = true;
                for (var i = 0; i < n; i++)
                {
                    if (graph[node][i] != 1 || visited[i]) continue;
                    tree.Nodes.Add(i);
                    if (initial.Contains(i))
                        tree.InitialNodes.Add(i);
                    nodes.Enqueue(i);
                }
            }

            trees.Add(tree);
        }
    }
}