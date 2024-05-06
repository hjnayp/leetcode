namespace source._0700;

public class Solution
{
    public int CherryPickup(int[][] grid)
    {
        int n = grid.Length;
        int[,] dp = new int[n, n];

        for (int i = 0; i < n; ++i)
        for (int j = 0; j < n; ++j)
            dp[i, j] = int.MinValue;

        dp[0, 0] = grid[0][0];

        for (int k = 1; k < n * 2 - 1; ++k)
        for (int x1 = Math.Min(k, n - 1); x1 >= Math.Max(k - n + 1, 0); --x1)
        for (int x2 = x1; x2 >= Math.Max(k - n + 1, 0); --x2)
        {
            int y1 = k - x1;
            int y2 = k - x2;

            if (grid[x1][y1] == -1 || grid[x2][y2] == -1)
            {
                dp[x1, x2] = int.MinValue;
                continue;
            }

            int res = dp[x1, x2];
            if (x1 > 0)
                res = Math.Max(res, dp[x1 - 1, x2]);
            if (x2 > 0)
                res = Math.Max(res, dp[x1, x2 - 1]);
            if (x1 > 0 && x2 > 0)
                res = Math.Max(res, dp[x1 - 1, x2 - 1]);

            res += grid[x1][y1];
            if (x1 != x2) res += grid[x2][y2];
            dp[x1, x2] = res;
        }

        return Math.Max(0, dp[n - 1, n - 1]);
    }
}