namespace source._1700._1706;

/// <summary>
///     <a href="https://leetcode.cn/problems/where-will-the-ball-fall">
///         1706. Where Will the Ball Fall
///     </a>
/// </summary>
public class Solution
{
    public int[] FindBall(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int[] fallPositions = new int[n];

        for (int i = 0; i < n; ++i)
        {
            fallPositions[i] = getFallPosition(i);
        }

        return fallPositions;

        int getFallPosition(int startCol)
        {
            int col = startCol;
            for (int i = 0; i < m; ++i)
            {
                int dir = grid[i][col];
                if (isStuck(i, col, dir))
                {
                    return -1;
                }

                col += dir;
            }

            return col;
        }

        bool isStuck(int row, int col, int dir)
        {
            int newCol = col + dir;
            return dir switch
            {
                -1 => newCol < 0 || grid[row][newCol] == 1,
                1 => newCol == n || grid[row][newCol] == -1,
                _ => false,
            };
        }
    }
}