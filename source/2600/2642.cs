namespace source._2600._2642
{
    public interface IGraph
    {
        void AddEdge(int[] edge);
        int ShortestPath(int node1, int node2);
    }

    namespace Dijkstra
    {
        public class Graph : IGraph
        {
            private readonly List<List<Tuple<int, int>>> _graph = new();

            public Graph(int n, int[][] edges)
            {
                _graph.Clear();
                for (var i = 0; i < n; ++i)
                    _graph.Add(new List<Tuple<int, int>>());
                foreach (int[] edge in edges)
                    _graph[edge[0]].Add(new Tuple<int, int>(edge[1], edge[2]));
            }

            public void AddEdge(int[] edge)
            {
                _graph[edge[0]].Add(new Tuple<int, int>(edge[1], edge[2]));
            }


            public int ShortestPath(int node1, int node2)
            {
                var distances = new int[_graph.Count];
                Array.Fill(distances, int.MaxValue);
                distances[node1] = 0;

                var queue = new PriorityQueue<Tuple<int, int>, int>();
                queue.Enqueue(new Tuple<int, int>(node1, 0), 0);

                while (queue.Count > 0)
                {
                    (int node, int distance) = queue.Dequeue();
                    if (node == node2) return distance;

                    foreach ((int to, int cost) in _graph[node])
                        if (distances[to] > distance + cost)
                        {
                            distances[to] = distance + cost;
                            queue.Enqueue(new Tuple<int, int>(to, distances[to]), distances[to]);
                        }
                }

                return -1;
            }
        }
    }

    namespace Floyd
    {
        public class Graph : IGraph
        {
            private readonly int[][] _distances;

            public Graph(int n, int[][] edges)
            {
                var nodeDistance = new int[n][];
                _distances = new int[n][];
                for (var i = 0; i < n; ++i)
                {
                    _distances[i] = new int[n];
                    Array.Fill(_distances[i], int.MaxValue);
                    _distances[i][i] = 0;
                }

                foreach (int[] edge in edges)
                    _distances[edge[0]][edge[1]] = edge[2];

                for (var k = 0; k < _distances.Length; ++k)
                for (var i = 0; i < _distances.Length; ++i)
                for (var j = 0; j < _distances.Length; ++j)
                    if (_distances[i][k] != int.MaxValue && _distances[k][j] != int.MaxValue)
                        _distances[i][j] = Math.Min(_distances[i][j], _distances[i][k] + _distances[k][j]);
            }

            public void AddEdge(int[] edge)
            {
                int from = edge[0],
                    to = edge[1],
                    cost = edge[2];

                if (cost >= _distances[from][to]) return;

                int n = _distances.Length;
                for (var i = 0; i < n; ++i)
                for (var j = 0; j < n; ++j)
                {
                    int a = _distances[i][from];
                    int b = _distances[to][j];

                    if (_distances[i][from] != int.MaxValue && _distances[to][j] != int.MaxValue)
                        _distances[i][j] = Math.Min(_distances[i][j], _distances[i][from] + cost + _distances[to][j]);
                }
            }


            public int ShortestPath(int node1, int node2)
            {
                bool unreachable = _distances[node1][node2] == int.MaxValue;
                return unreachable
                    ? -1
                    : _distances[node1][node2];
            }
        }
    }
}