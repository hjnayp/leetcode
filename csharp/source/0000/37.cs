namespace source._0000._37;

/// <summary>
///     <a href="https://leetcode.cn/problems/sudoku-solver">
///         Soduku Solver
///     </a>
/// </summary>
public class Solution
{
    private int[] _row = new int[9];
    private int[] _col = new int[9];
    private int[,] _box = new int[3, 3];
    private IList<(int, int)> _waitFilledCells = new List<(int, int)>();

    public void SolveSudoku(char[][] board)
    {
        for (int i = 0; i < 9; i++)
        for (int j = 0; j < 9; j++)
        {
            char ch = board[i][j];
            if (ch == '.')
            {
                _waitFilledCells.Add((i, j));
            }
            else
            {
                Flip(i, j, ch);
            }
        }

        Dfs(0);

        bool Dfs(int cellId)
        {
            if (cellId == _waitFilledCells.Count) return true;

            (int row, int col) = _waitFilledCells[cellId];
            int mask = ~(_row[row] | _col[col] | _box[row / 3, col / 3]) & 0x1ff;
            while (mask > 0)
            {
                int digit = LastOneDigit(mask & -mask);
                Flip(row, col, digit);
                board[row][col] = DigitToChar(digit);
                if (Dfs(cellId + 1)) return true;
                Flip(row, col, digit);

                mask &= mask - 1;
            }

            return false;
        }
    }

    private char DigitToChar(int digit)
    {
        return (char)('1' + digit);
    }

    private int LastOneDigit(int digit)
    {
        int pos = 0;
        while (pos < 10 && ((1 << pos) & digit) == 0)
        {
            ++pos;
        }

        return pos;
    }

    private void Flip(int row, int col, int digit)
    {
        _row[row] ^= 1 << digit;
        _col[col] ^= 1 << digit;
        _box[row / 3, col / 3] ^= 1 << digit;
    }

    private void Flip(int i, int j, char ch)
    {
        int digit = ch - '1';
        Flip(i, j, digit);
    }
}