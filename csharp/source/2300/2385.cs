using System.Xml;
using source.Structs;

namespace source._2300._2385;

public class Solution
{
    public int AmountOfTime(TreeNode root, int start)
    {
        Dictionary<int, List<int>> graph = new();
        BuildGraph(root);
        
        var res = 0;
        var nexts = new Queue<int>();
        nexts.Enqueue(start);
        HashSet<int> visited = new();
        while (nexts.Count > 0)
        {
            var nextLayer = new Queue<int>();
            while (nexts.Count > 0)
            {
                int n = nexts.Dequeue();
                visited.Add(n);
                foreach (int i in graph[n].Where(i => !visited.Contains(i)))
                    nextLayer.Enqueue(i);
            }

            if (nextLayer.Count > 0) ++res;
            nexts = nextLayer;
        }

        return res;

        void BuildGraph(TreeNode node)
        {
            var stack = new Stack<TreeNode>();
            stack.Push(node);

            while (stack.Any())
            {
                TreeNode n = stack.Pop();
                graph.TryAdd(n.val, new List<int>());
                if (n.left is not null)
                {
                    stack.Push(n.left);
                    graph[n.val].Add(n.left.val);
                    graph.TryAdd(n.left.val, new List<int>());
                    graph[n.left.val].Add(n.val);
                }

                if (n.right is not null)
                {
                    stack.Push(n.right);
                    graph[n.val].Add(n.right.val);
                    graph.TryAdd(n.right.val, new List<int>());
                    graph[n.right.val].Add(n.val);
                }
            }
        }
    }
}