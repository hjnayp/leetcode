namespace source._2700._2711;

/// <summary>
///     <a href="https://leetcode.cn/problems/difference-of-number-of-distinct-values-on-diagonals">
///         2711. Difference of Number of Distinct Values on Diagonals
///     </a>
/// </summary>
public class Solution
{
    public int[][] DifferenceOfDistinctValues(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;

        int[][] res = new int[m][];
        for (int i = 0; i < m; ++i)
        {
            res[i] = new int[n];
        }

        for (int i = 0; i < m; ++i)
        {
            int x = i;
            int y = 0;
            var nums = new HashSet<int>();
            while (x < m && y < n)
            {
                res[x][y] += nums.Count;
                int num = grid[x++][y++];
                nums.Add(num);
            }
        }

        for (int i = 1; i < n; ++i)
        {
            int x = 0;
            int y = i;
            var nums = new HashSet<int>();
            while (x < m && y < n)
            {
                res[x][y] += nums.Count;
                int num = grid[x++][y++];
                nums.Add(num);
            }
        }

        for (int i = 0; i < m; ++i)
        {
            var nums = new HashSet<int>();
            int x = i;
            int y = n - 1;

            while (x >= 0 && y >= 0)
            {
                res[x][y] -= nums.Count;
                res[x][y] = Math.Abs(res[x][y]);
                nums.Add(grid[x--][y--]);
            }
        }

        for (int i = n - 2; i >= 0; --i)
        {
            var nums = new HashSet<int>();
            int x = m - 1;
            int y = i;

            while (x >= 0 && y >= 0)
            {
                res[x][y] -= nums.Count;
                res[x][y] = Math.Abs(res[x][y]);
                nums.Add(grid[x--][y--]);
            }
        }

        return res;
    }
}