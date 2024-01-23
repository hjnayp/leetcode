namespace source._2100._2132;

public class Solution
{
    public bool PossibleToStamp(int[][] grid, int stamp_height, int stamp_width)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var sum = new int[m + 2][];
        var diff = new int[m + 2][];

        for (var i = 0; i < m + 2; i++)
        {
            sum[i] = new int[n + 2];
            diff[i] = new int[n + 2];
        }

        for (var i = 1; i <= m; i++)
        for (var j = 1; j <= n; j++)
            sum[i][j] = sum[i - 1][j] + sum[i][j - 1] - sum[i - 1][j - 1] + grid[i - 1][j - 1];

        for (var i = 1; i + stamp_height - 1 <= m; i++)
        for (var j = 1; j + stamp_width - 1 <= n; j++)
        {
            var x = i + stamp_height - 1;
            var y = j + stamp_width - 1;
            if (sum[x][y] - sum[x][j - 1] - sum[i - 1][y] + sum[i - 1][j - 1] != 0) continue;

            diff[i][j]++;
            diff[i][y + 1]--;
            diff[x + 1][j]--;
            diff[x + 1][y + 1]++;
        }

        for (var i = 1; i <= m; i++)
        for (var j = 1; j <= n; j++)
        {
            diff[i][j] += diff[i - 1][j] + diff[i][j - 1] - diff[i - 1][j - 1];
            if (diff[i][j] == 0 && grid[i - 1][j - 1] == 0)
                return false;
        }

        return true;
    }
}