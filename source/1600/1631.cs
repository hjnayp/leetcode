namespace source._1600._1631;

public class Solution
{
    private static readonly Tuple<int, int>[] Directions = { new(0, 1), new(0, -1), new(1, 0), new(-1, 0) };

    public int MinimumEffortPath(int[][] heights)
    {
        var m = heights.Length;
        var n = heights[0].Length;
        var left = 0;
        var right = 1000000;
        var res = 0;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            var queue = new Queue<Tuple<int, int>>();
            queue.Enqueue(new Tuple<int, int>(0, 0));
            var visited = new bool[m, n];
            visited[0, 0] = true;
            while (queue.Any())
            {
                var (x, y) = queue.Dequeue();
                foreach (var direction in Directions)
                {
                    var new_x = x + direction.Item1;
                    var new_y = y + direction.Item2;
                    if (new_x < 0 || new_x >= m || new_y < 0 || new_y >= n) continue;
                    if (visited[new_x, new_y] || Math.Abs(heights[x][y] - heights[new_x][new_y]) > mid) continue;

                    queue.Enqueue(new Tuple<int, int>(new_x, new_y));
                    visited[new_x, new_y] = true;
                }
            }

            if (visited[m - 1, n - 1])
            {
                res = mid;
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return res;
    }
}