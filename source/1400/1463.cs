namespace source._1400._1463;

public class Solution
{
    public int CherryPickup(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;

        int[,] dp = new int[n, n];
        for (int i = 0; i < n; ++i)
        for (int j = 0; j < n; ++j)
            dp[i, j] = GetPickedCherryValue(m - 1, i, j);

        for (int i = m - 2; i >= 0; --i)
        {
            int[,] dp2 = new int[n, n];
            for (int y1 = 0; y1 < n; ++y1)
            for (int y2 = 0; y2 < n; ++y2)
                dp2[y1, y2] = GetPreRowMaxValue(y1, y2) + GetPickedCherryValue(i, y1, y2);
            dp = dp2;
        }

        return dp[0, n - 1];

        int GetPickedCherryValue(int row, int col1, int col2)
        {
            int res = grid[row][col1];
            if (col1 != col2)
                res += grid[row][col2];

            return res;
        }

        int GetPreRowMaxValue(int y1, int y2)
        {
            int res = 0;
            for (int i = -1; i <= 1; ++i)
            {
                if (i + y1 < 0 || i + y1 >= n) continue;
                for (int j = -1; j <= 1; ++j)
                {
                    if (j + y2 < 0 || j + y2 >= n) continue;
                    res = Math.Max(res, dp[y1 + i, y2 + j]);
                }
            }

            return res;
        }
    }
}