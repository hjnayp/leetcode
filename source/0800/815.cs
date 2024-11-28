namespace source._0800._815;

/// <summary>
///     <a href="https://leetcode.cn/problems/bus-routes">
///         Bus Routes
///     </a>
/// </summary>
public class Solution
{
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        if (source == target) return 0;

        int n = routes.Length;
        bool[,] hasEdge = new bool[n, n];
        Dictionary<int, List<int>> nodeToRoutes = new();

        for (int i = 0; i < routes.Length; i++)
        {
            int[] routeNodes = routes[i];

            foreach (int u in routeNodes)
            {
                nodeToRoutes.TryAdd(u, []);

                foreach (int v in nodeToRoutes[u])
                {
                    hasEdge[i, v] = hasEdge[v, i] = true;
                }

                nodeToRoutes[u].Add(i);
            }
        }

        if (nodeToRoutes.TryGetValue(target, out List<int>? targets) == false
            || nodeToRoutes.TryGetValue(source, out _) == false)
        {
            return -1;
        }

        Queue<int> waitRoutes = new();
        bool[] hasVisited = new bool[n];
        HashSet<int> targetRoutes = targets.ToHashSet();
        foreach (int route in nodeToRoutes[source])
        {
            waitRoutes.Enqueue(route);
        }

        int res = 1;
        while (waitRoutes.Count > 0)
        {
            Queue<int> nextRoute = new();
            while (waitRoutes.Count > 0)
            {
                int route = waitRoutes.Dequeue();
                if (targetRoutes.Contains(route)) return res;

                if (hasVisited[route]) continue;
                hasVisited[route] = true;

                for (int i = 0; i < n; ++i)
                {
                    if (hasEdge[route, i] && hasVisited[i] == false)
                    {
                        nextRoute.Enqueue(i);
                    }
                }
            }

            waitRoutes = nextRoute;
            ++res;
        }

        return -1;
    }
}