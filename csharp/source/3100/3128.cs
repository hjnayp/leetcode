namespace source._3100._3128;

/// <summary>
///     https://leetcode.cn/problems/right-triangles
/// </summary>
public class Solution
{
    public long NumberOfRightTriangles(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;

        int[] rowTrueCounts = new int[m];
        int[] columnTrueCounts = new int[n];

        for (int i = 0; i < m; i++)
        for (int j = 0; j < n; ++j)
        {
            if (grid[i][j] == 0) continue;

            rowTrueCounts[i]++;
            columnTrueCounts[j]++;
        }

        long rightTriangleCount = 0;
        for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            if (grid[i][j] == 0) continue;

            rightTriangleCount += CountRightTriangleCount(i, j);
        }

        return rightTriangleCount;

        long CountRightTriangleCount(int row, int column)
        {
            int rowTrueCount = rowTrueCounts[row] - 1;
            int columnTrueCount = columnTrueCounts[column] - 1;
            return rowTrueCount * columnTrueCount;
        }
    }
}