namespace source._0000._36;

/// <summary>
///     <a href="https://leetcode.cn/problems/valid-sudoku">
///         Valid Sudoku
///     </a>
/// </summary>
public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        int[,] column = new int[9, 9];
        int[,] row = new int[9, 9];
        int[,,] subBox = new int[3, 3, 9];
        for (int i = 0; i < 9; i++)
        for (int j = 0; j < 9; j++)
        {
            char ch = board[i][j];
            if (ch == '.') continue;

            int chI = ch - '0' - 1;
            if (++row[i, chI] > 1) return false;
            if (++column[j, chI] > 1) return false;
            if (++subBox[i / 3, j / 3, chI] > 1) return false;
        }

        return true;
    }
}