namespace source._0000._52;

/// <summary>
///     <a href="https://leetcode.cn/problems/n-queens-ii">
///         52. N-Queens II
///     </a>
/// </summary>
public class Solution
{
    public int TotalNQueens(int n)
    {
        int nPosition = (1 << n) - 1;
        return BackTrack(0, 0, 0, 0);

        int BackTrack(int row, int columns, int diagonals, int antiDiagonals)
        {
            if (row == n) return 1;
            int position = nPosition & ~(columns | diagonals | antiDiagonals);
            int count = 0;

            while (position != 0)
            {
                int column = position & -position;
                position ^= column;
                count += BackTrack(row + 1, columns | column, (diagonals | column) << 1, (antiDiagonals | column) >> 1);
            }

            return count;
        }
    }
}