namespace source._3100._3127;

/// <summary>
///     <a href="https://leetcode.cn/problems/make-a-square-with-the-same-color">
///         Make a Square with the Same Color
///     </a>
/// </summary>
public class Solution
{
    public bool CanMakeSquare(char[][] grid)
    {
        for (int row = 0; row < grid.Length; row++)
        for (int col = 0; col < grid[row].Length - 1; col++)
        {
            if (grid[row][col] != grid[row][col + 1]) continue;
            char color = grid[row][col];
            if (HasSameColor(row, col, color)) return true;
        }

        return false;

        bool HasSameColor(int row, int col, char color)
        {
            if (row > 0)
            {
                int prevRow = row - 1;
                if (grid[prevRow][col] == color ||
                    grid[prevRow][col + 1] == color)
                {
                    return true;
                }
            }

            if (row < grid.Length - 1)
            {
                int nextRow = row + 1;
                if (grid[nextRow][col] == color ||
                    grid[nextRow][col + 1] == color)
                {
                    return true;
                }
            }

            return false;
        }
    }
}