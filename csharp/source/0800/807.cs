namespace source._0800._807;

public class Solution
{
    public int MaxIncreaseKeepingSkyline(int[][] grid)
    {
        int n = grid.Length;
        int[] maxColumn = new int[n];
        int[] maxRow = new int[n];

        for (int i = 0; i < n; ++i)
        for (int j = 0; j < n; ++j)
        {
            maxRow[i] = Math.Max(maxRow[i], grid[i][j]);
            maxColumn[j] = Math.Max(maxColumn[j], grid[i][j]);
        }

        int addHeightSum = 0;
        for (int i = 0; i < n; ++i)
        for (int j = 0; j < n; ++j)
        {
            addHeightSum += Math.Min(maxRow[i], maxColumn[j]) - grid[i][j];
        }

        return addHeightSum;
    }
}