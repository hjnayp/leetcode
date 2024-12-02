namespace source._0000._51;

/// <summary>
///     <a href="https://leetcode.cn/problems/n-queens">
///         51. N-Queens
///     </a>
/// </summary>
public class Solution
{
    public IList<IList<string>> SolveNQueens(int n)
    {
        Dictionary<int, string> rowTemplates = new();
        for (int i = 0; i < n; i++)
        {
            rowTemplates[1 << i] = new string('.', i) + 'Q' + new string('.', n - i - 1);
        }

        int nPosition = (1 << n) - 1;
        List<IList<string>> result = [];
        IList<int> rows = [];
        Backtrack(0, rows, 0, 0, 0);

        return result;

        void Backtrack(int row, IList<int> rows, int columns, int diagonals, int antiDiagonals)
        {
            if (row == n)
            {
                result.Add(rows.Select(i => rowTemplates[i]).ToList());
                return;
            }

            int availableColumns = nPosition & ~(columns | diagonals | antiDiagonals);
            while (availableColumns != 0)
            {
                int column = availableColumns & -availableColumns;
                availableColumns ^= column;

                rows.Add(column);
                Backtrack(row + 1, rows, columns | column, (diagonals | column) << 1, (antiDiagonals | column) >> 1);
                rows.RemoveAt(rows.Count - 1);
            }
        }
    }
}