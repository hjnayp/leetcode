namespace source._0000._63;

/// <summary>
///     <a href="https://leetcode.cn/problems/unique-paths-ii">
///         63. Unique Paths II
///     </a>
/// </summary>
public class Solution
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        int n = obstacleGrid.Length;
        int m = obstacleGrid[0].Length;
        int[] f = new int[m];
        f[0] = obstacleGrid[0][0] == 0 ? 1 : 0;

        for (int i = 0; i < n; ++i)
        for (int j = 0; j < m; ++j)
        {
            if (obstacleGrid[i][j] == 1)
            {
                f[j] = 0;
            }
            else if (j > 0 && obstacleGrid[i][j - 1] == 0)
            {
                f[j] += f[j - 1];
            }
        }

        return f[m - 1];
    }
}