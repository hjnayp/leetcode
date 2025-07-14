namespace source._3100._3142;

public class Solution
{
    public bool SatisfiesConditions(int[][] grid)
    {
        int n = grid[0].Length;
        int m = grid.Length;
        for (int i = 0; i < n; ++i)
        {
            if (i > 0 &&
                grid[0][i] == grid[0][i - 1])
            {
                return false;
            }

            for (int j = 0; j < m; ++j)
            {
                if (j > 0 &&
                    grid[j][i] != grid[j - 1][i])
                {
                    return false;
                }
            }
        }

        return true;
    }
}