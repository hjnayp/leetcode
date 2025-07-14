namespace source._1600._1631;

public class Solution
{
    private static readonly Tuple<int, int>[] s_Directions = { new(0, 1), new(0, -1), new(1, 0), new(-1, 0) };

    public int MinimumEffortPath(int[][] heights)
    {
        int m = heights.Length;
        int n = heights[0].Length;
        var left = 0;
        var right = 1000000;
        var res = 0;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            var queue = new Queue<Tuple<int, int>>();
            queue.Enqueue(new Tuple<int, int>(0, 0));
            var visited = new bool[m, n];
            visited[0, 0] = true;
            while (queue.Any())
            {
                (int x, int y) = queue.Dequeue();
                foreach (Tuple<int, int> direction in s_Directions)
                {
                    int newX = x + direction.Item1;
                    int newY = y + direction.Item2;
                    if (newX < 0 || newX >= m || newY < 0 || newY >= n) continue;
                    if (visited[newX, newY] || Math.Abs(heights[x][y] - heights[newX][newY]) > mid) continue;

                    queue.Enqueue(new Tuple<int, int>(newX, newY));
                    visited[newX, newY] = true;
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